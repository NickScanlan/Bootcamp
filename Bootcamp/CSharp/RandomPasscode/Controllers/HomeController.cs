using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;
namespace RandomPasscode.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {        
        int? number = HttpContext.Session.GetInt32("number");
        if(number == null)
        {
            number = 1;
        }
        else
        {
            number += 1;
        }
        HttpContext.Session.SetInt32("number", number.GetValueOrDefault());
        
        
        HttpContext.Session.SetString("passcode", "");
        string? passcode = HttpContext.Session.GetString("passcode");
        if(passcode == "")
        {
            passcode = "press generate to generate passcode";
        }


        
        
        


        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    

}
