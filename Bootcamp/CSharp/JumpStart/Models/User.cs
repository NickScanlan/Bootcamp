#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JumpStart.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    [Required(ErrorMessage ="Name is Required")]
    [MinLength(2, ErrorMessage ="Must be at least 2 Characters")]
    [Display (Name = "First Name:")]
    public string FirstName { get; set; } 
    
    [Required(ErrorMessage ="Name is Required")]
    [MinLength(2, ErrorMessage ="Must be at least 2 Characters")]
    [Display (Name = "Last Name:")]
    public string LastName { get; set; } 
    
    [Required (ErrorMessage ="Required")]
    [Display (Name = "Email:")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [Required (ErrorMessage ="Required")]
    [MinLength(8, ErrorMessage ="Must be at least 8 Characters")]
    [DataType(DataType.Password)]
    [Display (Name = "Password:")]
    public string Password { get; set; }

    [NotMapped]
    [Required (ErrorMessage ="Required")]
    [DataType(DataType.Password)]
    [Display (Name = "Confirm Password:")]
    public string ConfirmPassword { get; set; }
    
    
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;





List<Project> StartupProjects { get; set; } = new List<Project>();

public List<UserProjectSupport> UserSupports { get; set; } = new List<UserProjectSupport>{};

}
