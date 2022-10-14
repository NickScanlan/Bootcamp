#pragma warning disable CS8618


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]

public class LoginUser
{

    [Required (ErrorMessage ="Required")]
    [DataType(DataType.EmailAddress)]
    [Display(Name ="Email Address:")]
    public string LoginEmail { get; set; }

    [Required (ErrorMessage ="Required")]
    [DataType(DataType.Password)]
    [Display(Name ="Password:")]
    public string LoginPassword { get; set; }
}

