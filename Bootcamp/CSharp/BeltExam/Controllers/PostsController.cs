using BeltExam.Models;
using Microsoft.AspNetCore.Mvc;

public class PostsController : Controller

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

     private BeltExamContext db;
     public PostsController(BeltExamContext context)
     {
        db = context;
     }

     [HttpGet("/posts")]
      public IActionResult All()
      {
         List<Post> allPosts = db.Posts.ToList();
         return View("All", allPosts);
      }

      [HttpGet("posts/new")]
      public IActionResult New()
      {
      return View ("New");
      }

      [HttpPost("posts/create")]
      public IActionResult Create(Post newPost)
      {
         if (!loggedIn || uid == null)
        {
            return RedirectToAction("Index", "Users");
        }

         if(!ModelState.IsValid)
         {
            return New();
         }
         newPost.UserId = (int)uid;
         db.Posts.Add(newPost);
         db.SaveChanges();

         return RedirectToAction("All");

      }

      [HttpGet("/posts/{onePostId}")]
      public IActionResult GetOnePost(int onePostId)
      {
         Post? post = db.Posts.FirstOrDefault(p => p.PostId == onePostId);

         if(post == null)
         {
            return RedirectToAction("All");
         }
         return View ("One", post);
      }

      [HttpPost ("/posts/{deletePostId}/delete")]
      public IActionResult DeletePost(int deletePostId)
      {
         Post? post = db.Posts.FirstOrDefault(p => p.PostId == deletePostId);

         if(post != null)
         {
            db.Posts.Remove(post);
            db.SaveChanges();
         }

         return RedirectToAction("All");
      }
      

      [HttpGet("/posts/{editPostId}/edit")]
      public IActionResult Edit(int postId)
      {
         Post? post = db.Posts.FirstOrDefault(p => p.PostId == postId);
         if(post == null)
         {
            return RedirectToAction("All");
         }

         return View("Edit", post);
      }

      [HttpPost("/post/{postId}/update")]
      public IActionResult Update(Post editPost, int postId)
      {
         if(ModelState.IsValid == false)
         {
            return Edit(postId);
         }
         Post? dbPost = db.Posts.FirstOrDefault(post => post.PostId == postId);

         if(dbPost == null)
         {
            return RedirectToAction("All");
         }

         
         dbPost.img = editPost.img;
         dbPost.title = editPost.title;
         dbPost.medium = editPost.medium;
         dbPost.forsale = editPost.forsale;
         dbPost.UpdatedAt = DateTime.Now;

         db.Posts.Update(dbPost);
         db.SaveChanges();



         return RedirectToAction("GetOnePost", new {postId = dbPost.PostId});
         
      }

}