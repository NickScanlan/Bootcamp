#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace MeetUp.Models;


public class Meeting
{
    [Key]

    public int MeetingId { get; set; }

    [Required(ErrorMessage ="Meeting Must Have Title")]
    [Display(Name ="Title:")]
    public string Title { get; set; }

    [Display(Name="Description:")]
    [Required(ErrorMessage ="Must Have Description")]
    public string Description { get; set; }

    [Required(ErrorMessage ="When is the Meeting")]
    [Display(Name="Meeting Date and Time:")]
    public DateTime MeetingDate { get; set;}


    [Display(Name="Duration:")]
    public int Duration { get; set; } 

    [Display(Name="DurationTime:")]
    [Required(ErrorMessage ="Must Have DurationTime")]
    public string DurationTime { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    public int UserId { get; set; }
    public User? Coordinator { get; set; }

public List<UserMeetingSignup> MeetingSignups { get; set; } = new List<UserMeetingSignup>();
}