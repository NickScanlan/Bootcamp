#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
namespace chefs_and_dishes.Models;


public class Chefs
{
    [Key]

    
    public int chefID { get; set; }

    [Required]
    [Display (Name = "First Name")]
    public string first_name { get; set; }
    
    [Required]
    [Display (Name = "Last Name")]
    public string last_name { get; set; }

    public List<Dishes>? NumofDishes { get; set;}

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt {get; set; } 
  
   
}