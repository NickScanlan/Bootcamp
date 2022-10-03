
#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
    [Display(Name = "Name:")]
    public string Name {get; set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Location:")]
    public string Location {get; set;}

    [Display(Name = "Language:")]
    [Required(ErrorMessage = "is required")]
    public string Language {get; set;}

    [MinLength(20, ErrorMessage = "Comment must be more than 20 Characters")]
    [Display(Name = "Comment:")]
    public string Comment {get; set;}
}


 