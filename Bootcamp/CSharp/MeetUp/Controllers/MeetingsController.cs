
using MeetUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MeetingsController : Controller

{
    private int? uid
     {
         get
        {
            return HttpContext.Session.GetInt32("UUID");
        }
     }

     private bool loggedIn
     {
        get
        {
            return uid != null;
        }
     }

     private MeetUpContext db;
     public MeetingsController(MeetUpContext context)
     {
        db = context;
     }

     [HttpGet("/meetings")]
      public IActionResult All()
      {
         List<Meeting> allMeetings = db.Meetings
         .Include(v => v.Coordinator).Include(d => d.MeetingSignups).OrderBy(d => d.MeetingDate)
         .ToList();
         return View("All", allMeetings);
         
      }

      [HttpGet("meetings/new")]
      public IActionResult New()
      {
      return View ("New");
      }

      [HttpPost("meetings/create")]
      public IActionResult Create(Meeting newMeeting)
      {
         if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }
        //end date conditional must be in future

         if(!ModelState.IsValid)
         {
            return New();
         }
      
         newMeeting.UserId = (int)uid;
         db.Meetings.Add(newMeeting);
         db.SaveChanges();

         return RedirectToAction("All");

      }

      [HttpGet("/meetings/{oneMeetingId}")]
      public IActionResult GetOneMeeting(int oneMeetingId)
      {
         Meeting? meeting = db.Meetings.FirstOrDefault(p => p.MeetingId == oneMeetingId);

         Meeting? Meeting = db.Meetings
            .Include(v => v.Coordinator)
            // .Include(v => v.MeetingParticipants)
            .FirstOrDefault(v => v.MeetingId == oneMeetingId);


         if(meeting == null)
         {
            return RedirectToAction("All");
         }
         return View ("One", meeting);
      }

      [HttpPost ("/meetings/{deleteMeetingId}/delete")]
      public IActionResult DeleteOneMeeting(int deleteMeetingId)
      {
         Meeting? meeting = db.Meetings.FirstOrDefault(p => p.MeetingId == deleteMeetingId);

         if(meeting != null && meeting.UserId == uid)
         {
            db.Meetings.Remove(meeting);
            db.SaveChanges();
            return RedirectToAction("All"); 
         }

         return RedirectToAction("All"); 
      }

    [HttpGet("/meetings/{meetingId}/signup")]
    public IActionResult Signup(int meetingId)
    {
        if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }

        UserMeetingSignup? existingSignup = db.UserMeetingSignups
            .FirstOrDefault(l => l.MeetingId == meetingId && l.UserId == (int)uid);

        if (existingSignup == null)
        {
            UserMeetingSignup newSignup = new UserMeetingSignup()
            {
                UserId = (int)uid,
                MeetingId = meetingId
            };

            db.UserMeetingSignups.Add(newSignup);
        }
        else
        {
            db.UserMeetingSignups.Remove(existingSignup);
        }

        db.SaveChanges();
        return RedirectToAction("All");
    }
}

