using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyWithValidation.Models;

namespace SurveyWithValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    
    public IActionResult Index()
    {
        return View();
    }

    
    [HttpPost("/results")]
    public IActionResult Results(User newUser)
    {
        if(ModelState.IsValid)
        { 
            return View("results", newUser);
        }
        
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
