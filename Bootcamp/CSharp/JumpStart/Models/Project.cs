#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace JumpStart.Models;

public class Project
{
    [Key]
    public int ProjectId { get; set; }

    [Required (ErrorMessage = "Project Title Required")]
    [Display (Name = "Title:")]
    public string title { get; set; }

    [Required (ErrorMessage ="Project Goal Required")]
    [MinLength(0, ErrorMessage ="Goal must be Positive")]
    [Display (Name = "Goal:")]
    public int goal { get; set; }

    [Required (ErrorMessage = "Project Deadline Required")]
    [Display (Name = "Deadline:")]
    public DateTime deadline { get; set; }  

    [Required (ErrorMessage = "Project Description Required")]
    [MinLength(20, ErrorMessage ="Must be at least 20 Characters")]
    [Display (Name = "Description:")]
    public string description {get; set;}
    
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;



    
    
    public int UserId { get; set; }
    public User? Creator { get; set; }
    public List<UserProjectSupport> ProjectSupports { get; set; } = new List<UserProjectSupport>{};

}
