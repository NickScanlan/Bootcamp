#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace MeetUp.Models;


public class MeetUpContext : DbContext
{
    public MeetUpContext(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<UserMeetingSignup> UserMeetingSignups { get; set; }
}