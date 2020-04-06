using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurrentMood.Models
{
  public class CurrentMoodContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Message> Messages { get; set; }
    public CurrentMoodContext(DbContextOptions options) : base(options) { }
  }
} 