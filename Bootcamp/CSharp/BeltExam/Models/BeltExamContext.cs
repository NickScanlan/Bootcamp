#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace BeltExam.Models;


public class BeltExamContext : DbContext
{
    public BeltExamContext(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

}