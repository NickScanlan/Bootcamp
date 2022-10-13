using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using chefs_and_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Controllers;

public class HomeController : Controller
{
  
    private chefs_and_dishesContext dbContext;

    
    public HomeController(chefs_and_dishesContext context)
    {
        dbContext = context;
    }

    
    [HttpGet("")]
    public IActionResult Chefs()
    {   
        List<Chefs>? AllChefs = dbContext.Chefs.Include(c => c.NumofDishes).ToList();
        return View();
    }


    [HttpGet("dishes")]
    public IActionResult Dishes()
    {
        List<Dishes> EveryDish = dbContext.Dishes.Include(d => d.ChefName).ToList();
        return View("dishes"); 
    }

    [HttpGet("/addchef")]
    public IActionResult NewChef()
    {
        return View ("AddChef");
    }   

    [HttpPost("InsertChef")]
    public IActionResult insertChef(Chefs newChef)
    {
        if(ModelState.IsValid)
        {
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return RedirectToAction("/");
        }
        else
        {
            return Redirect("/");
        }
    }
    
    
    [HttpGet("/adddish")]
    public IActionResult NewDish()
    {
        List<Chefs>? EveryChef = dbContext.Chefs.ToList();
        ViewBag.AllChefs = EveryChef;
        return View ("AddDish");
    }

    [HttpPost("InsertDish")]
    public IActionResult insertDish(Dishes newDish)
    {
        if(ModelState.IsValid)
        {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("dishes");
        }
        else
        {
            return Redirect("/");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}



