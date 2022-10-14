#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;


public class Wedding
{
    [Key]

    public int WeddingId { get; set; }

    [Required(ErrorMessage ="Must Have Name")]
    [Display(Name ="Wedder One")]
    public string WedderOne { get; set; }

    [Display(Name="Wedder Two ")]
    [Required(ErrorMessage ="Must Have Name")]
    public string WedderTwo { get; set; }

    [Required(ErrorMessage ="When is the Wedding")]
    [Display(Name="Wedding Date")]
    public DateTime WeddingDate { get; set;}

    [Required(ErrorMessage ="Address Required")]
    [Display(Name="Wedding Address ")]
    public string Address { get; set; } 

    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    public int UserId { get; set; }
    public User? Planner { get; set; }


    public List<UserWeddingSignup> WeddingSignups { get; set; } = new List<UserWeddingSignup>{};
}