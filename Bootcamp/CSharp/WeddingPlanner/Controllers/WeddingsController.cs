using WeddingPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class WeddingsController : Controller
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

    private WeddingPlannerContext db;
    public WeddingsController(WeddingPlannerContext context)
    {
        db = context;
    }

    [HttpGet("/weddings/new")]
    public IActionResult New()
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }
        return View("New");
    }

    [HttpPost("/weddings/create")]
    public IActionResult Create(Wedding newWedding)
    {
        if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }
        if (!ModelState.IsValid)
        {
            // send back to the page w/ the form so error messages are displayed
            // can call the New() function because we didn't default the returned view within it
            // allows that method to run w/o creating a new request response cycle (so we keep our errors)
            return New();
        }

        // attaching currently logged in user's ID to the newWedding
        newWedding.UserId = (int)uid;

        Console.WriteLine(newWedding.WeddingId);
        // ModelState IS valid
        db.Weddings.Add(newWedding);
        // db doesn't update until we run save changes
        // after SaveChanges, our newWedding object will have its WeddingId updated from the db auto-generated id
        db.SaveChanges();
        Console.WriteLine(newWedding.WeddingId);

        return RedirectToAction("All");

        /*
        The ORM .Add method generated a SQL insert mapping the new Wedding properties
        to their corresponding SQL columns, like so:

        INSERT INTO Weddings (Topic, Body, ImgUrl, CreatedAt, UpdatedAt)
        VALUES (newWedding.Topic, newWedding.Body, newWedding.ImgUrl, NOW(), NOW());
        */
    }

    [HttpGet("/weddings")]
    public IActionResult All()
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }

        // get all Weddings, and include author info for each individual Wedding in addition to the foreign key
        List<Wedding> allWeddings = db.Weddings
            // .Include always gives you the entity from the queried table, so both
            // .Include statements refer to Wedding
            .Include(v => v.Planner)
            .Include(v => v.WeddingSignups)
            .ToList();
            // ^ what you would have to write in SQL
        // SELECT * FROM Weddings JOIN users on Wedding.UserId = user.UserId

        return View("All", allWeddings);
    }

    [HttpGet("/weddings/{oneWeddingId}")]
    public IActionResult GetOneWedding(int oneWeddingId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }
        Wedding? Wedding = db.Weddings
            .Include(v => v.Planner)
            .Include(v => v.WeddingSignups)
            .FirstOrDefault(v => v.WeddingId == oneWeddingId);

        // In case user manually types in an invalid ID in the url
        if (Wedding == null)
        {
            return RedirectToAction("All");
        }

        return View("ViewOne", Wedding);
    }

    [HttpPost("/weddings/{deletedWeddingId}/delete")]
    public IActionResult DeleteWedding(int deletedWeddingId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }
        Wedding? wedding = db.Weddings.FirstOrDefault(p => p.WeddingId == deletedWeddingId);

        if (wedding != null && wedding.UserId == uid)
        {
            db.Weddings.Remove(wedding);
            db.SaveChanges();
        }
        return RedirectToAction("All");
    }

    [HttpGet("/Weddings/{weddingId}/edit")]
    public IActionResult Edit(int weddingId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }
        Wedding? wedding = db.Weddings.FirstOrDefault(p => p.WeddingId == weddingId);

        if(wedding == null || wedding.UserId != uid)
        {
            return RedirectToAction("All");
        }

        return View("Edit", wedding);
    }

    [HttpPost("/weddings/{weddingId}/update")]
    public IActionResult Update(Wedding editedWedding, int weddingId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "Users");
        }
        if (ModelState.IsValid == false)
        {
            return Edit(weddingId);
        }

        Wedding? dbWedding = db.Weddings.FirstOrDefault(wedding => wedding.WeddingId == weddingId);

        if (dbWedding == null || dbWedding.UserId != uid)
        {
            return RedirectToAction("All");
        }

        dbWedding.WedderOne = editedWedding.WedderOne;
        dbWedding.WedderTwo = editedWedding.WedderTwo;
        dbWedding.WeddingDate = editedWedding.WeddingDate;
        dbWedding.Address = editedWedding.Address;
        dbWedding.UpdatedAt = DateTime.Now;

        db.Weddings.Update(dbWedding);
        db.SaveChanges();

        // return Redirect($"/Weddings/{dbWedding.WeddingId}");
        return RedirectToAction("GetOneWedding", new { WeddingId = dbWedding.WeddingId });
    }

    [HttpPost("/weddings/{weddingId}/signup")]
    public IActionResult Signup(int weddingId)
    {
        if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }

        UserWeddingSignup? existingSignup = db.UserWeddingSignups
            .FirstOrDefault(l => l.WeddingId == weddingId && l.UserId == (int)uid);

        if (existingSignup == null)
        {
            UserWeddingSignup newSignup = new UserWeddingSignup()
            {
                UserId = (int)uid,
                WeddingId = weddingId
            };

            db.UserWeddingSignups.Add(newSignup);
        }
        else
        {
            db.UserWeddingSignups.Remove(existingSignup);
        }

        db.SaveChanges();
        return RedirectToAction("All");
    }
}