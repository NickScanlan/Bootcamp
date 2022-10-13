#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
namespace chefs_and_dishes.Models;


public class Dishes
{
    [Key]

    
    public int dishID { get; set; }

    [Required]
    [Display (Name = "Name of Dish")]
    public string dish_name { get; set; }
    
    [Required]
    [Display(Name = "Tastiness")]
    public int tastiness { get; set;}
    
    [Required]
    [Display(Name = "Calories")]
    public int calories { get; set;}

    [Display (Name = "Chef")]
    public int chefID { get; set; }

    public Chefs? ChefName { get; set;}

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt {get; set; } 
  
   
}