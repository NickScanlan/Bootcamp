#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    [Required(ErrorMessage ="Name is Required")]
    [MinLength(2, ErrorMessage ="Must be at least 2 Characters")]
    [Display (Name = "Name:")]
    public string Name { get; set; } 
    
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


    public List<Post> UserPosts { get; set; } = new List<Post>();
}

