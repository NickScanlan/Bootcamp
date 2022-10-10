#pragma warning disable CS8618


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class LoginUser
{
    [Required(ErrorMessage ="required")]
    [Display(Name = "Email:")]
    public string LoginEmail { get; set; }
    
    [Required(ErrorMessage ="required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password:")]
    public string LoginPassword { get; set; }
}