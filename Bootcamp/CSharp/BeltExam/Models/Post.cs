#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int PostId { get; set; }

    [Required (ErrorMessage = "Post Name Required")]
    [Display (Name = "Image in URL Format:")]
    public string img { get; set; }

    [Required (ErrorMessage ="Post Title Required")]
    [Display (Name = "Title:")]
    public string title { get; set; }

    [Required (ErrorMessage = "Post Medium Required")]
    [Display (Name = "Medium:")]
    public string medium { get; set; }  

    // [Required (ErrorMessage = "Is This Piece For Sale?")]
    [Display (Name = "For Sale?")]
    public bool forsale {get; set;}
    
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;



    
    
    public int UserId { get; set; }

    public User? Artist { get; set; }

}
