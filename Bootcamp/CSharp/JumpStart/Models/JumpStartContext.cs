#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace JumpStart.Models;


public class JumpStartContext : DbContext
{
    public JumpStartContext(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<UserProjectSupport> UserProjectSupports { get; set; }


}