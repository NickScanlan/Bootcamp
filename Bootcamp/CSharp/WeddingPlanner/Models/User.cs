#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;


public class User 
{
    [Key]

    public int UserId { get; set; }


    [Required (ErrorMessage ="Required")]
    [Display (Name =" First Name")]
    public string FirstName { get; set; }


    [Required (ErrorMessage ="Required")]
    [Display (Name ="Last Nmae:")]
    public string LastName { get; set; }

    [Required (ErrorMessage ="Required")]
    [Display (Name ="Email:")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required (ErrorMessage ="Required")]
    [MinLength(8, ErrorMessage ="Must be at least 8 characters")]
    [Display (Name ="Password:")]
    public string Password { get; set; }

    [NotMapped]
    [DataType(DataType.Password)]
    [Compare ("Password", ErrorMessage ="Passwords Don't Match")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    List<Wedding> PlannedWeddings { get; set; } = new List<Wedding>{};

    public List<UserWeddingSignup> UserSignups { get; set; }
}