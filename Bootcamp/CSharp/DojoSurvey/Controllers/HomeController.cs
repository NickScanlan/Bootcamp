using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {   
        return View("index");
    }


    [HttpPost("/results")]
    public IActionResult Results(string name, string location, string language, string comment)
    {
        List<string> surveyInfo = new List<string>
        {
            $"{name}", $"{location}", $"{language}", $"{comment}"
        };
        
        
        ViewBag.SurveyInfo = surveyInfo;
        
        
        Console.WriteLine(surveyInfo[2]); 
        return View("results");
    }



}

