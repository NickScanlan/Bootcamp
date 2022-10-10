using LoginAndRegistration;
using LoginAndRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


public class UsersController : Controller
{
    private LoginAndRegistrationContext db;

    public UsersController(LoginAndRegistrationContext context)
    {
        db = context;
    }


    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }


    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
        if(ModelState.IsValid)
        {
            if(db.Users.Any(u => u.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "is taken");
            }
        }
        
        if(ModelState.IsValid == false)
        {
            return Index();
        }
    PasswordHasher<User> hashBrown = new PasswordHasher<User>();
    newUser.Password = hashBrown.HashPassword(newUser, newUser.Password);
    
    db.Users.Add(newUser);
    db.SaveChanges();

    HttpContext.Session.SetInt32("UUID", newUser.UserId);
    return RedirectToAction("success");
    }


    [HttpPost ("/login")]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid == false)
        {
            return Index();
        }
        User? dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);

        if(dbUser == null)
        {
            ModelState.AddModelError("LoginEmail", "Not Found");
            return Index();
        }

        PasswordHasher<LoginUser> hashBrown = new PasswordHasher<LoginUser>();

        PasswordVerificationResult pwCompareResult = hashBrown.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
        
        if (pwCompareResult == 0)
        {
            ModelState.AddModelError("LoginPassword", "wrong credentials");
        }

        HttpContext.Session.SetInt32("UUID", dbUser.UserId);
        return RedirectToAction("success");
    }
    

    [HttpPostAttribute("/logout")]

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

}

