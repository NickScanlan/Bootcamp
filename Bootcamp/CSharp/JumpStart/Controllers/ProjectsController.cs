using JumpStart.Models;
using Microsoft.AspNetCore.Mvc;

public class ProjectsController : Controller

{
    private int? uid
     {
         get
        {
            return HttpContext.Session.GetInt32("UUID");
        }
     }

     private bool loggedIn
     {
        get
        {
            return uid != null;
        }
     }

     private JumpStartContext db;
     public ProjectsController(JumpStartContext context)
     {
        db = context;
     }

     [HttpGet("/projects")]
      public IActionResult All()
      {
         List<Project> allProjects = db.Projects.ToList();
         return View("All", allProjects);
      }

      [HttpGet("projects/new")]
      public IActionResult New()
      {
      return View ("New");
      }

      [HttpPost("projects/create")]
      public IActionResult Create(Project newProject)
      {
         if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }
        //end date conditional must be in future

         if(!ModelState.IsValid)
         {
            return New();
         }
      
         newProject.UserId = (int)uid;
         db.Projects.Add(newProject);
         db.SaveChanges();

         return RedirectToAction("All");

      }

      [HttpGet("/projects/{oneProjectId}")]
      public IActionResult GetOneProject(int oneProjectId)
      {
         Project? project = db.Projects.FirstOrDefault(p => p.ProjectId == oneProjectId);

         if(project == null)
         {
            return RedirectToAction("All");
         }
         return View ("One", project);
      }

      [HttpPost ("/projects/{deleteProjectId}/delete")]
      public IActionResult DeleteOneProject(int deleteProjectId)
      {
         Project? project = db.Projects.FirstOrDefault(p => p.ProjectId == deleteProjectId);

         if(project != null && project.UserId == uid)
         {
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("All"); 
         }

         return RedirectToAction("All"); 
      }
      
 [HttpPost("/projects/{projectId}/support")]
    public IActionResult Support(int projectId, UserProjectSupport support)
    {
        if (!loggedIn || uid == null)
        {
            return RedirectToAction("All", "Users");
        }

        UserProjectSupport? existingSupport = db.UserProjectSupports
            .FirstOrDefault(p => p.ProjectId == projectId && p.UserId == (int)uid);
        
        db.SaveChanges();
        return RedirectToAction("All");
    }


}