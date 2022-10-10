#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAndRegistration;
public class User
{
    [Key]

    public int UserId { get; set;}

    
    [Required(ErrorMessage ="required")]
    [MinLength(2, ErrorMessage ="must be more than 2 characters ")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
   
    [Required(ErrorMessage ="required")]
    [MinLength(2, ErrorMessage ="must be more than 2 characters ")]
    [Display(Name = "Last Name:")]
    public string LastName { get; set; }
    
    
    [Display(Name = "Email:")]
    [Required(ErrorMessage ="required")]
    [EmailAddress]
    public string Email { get; set; }
   
    [Required(ErrorMessage ="required")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    [Display(Name = "Password:")]
    public string Password { get; set; }
    
    [NotMapped]
    [Compare("Password", ErrorMessage ="Doesn't match password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage ="required")]
    [Display(Name = "Confirm Password:")]
    public string ConfirmPassword { get; set; }
    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;



}