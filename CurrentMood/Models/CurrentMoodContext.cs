using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurrentMood.Models
{
  public class CurrentMoodContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Chat> Chats { get; set; }
    public CurrentMoodContext(DbContextOptions options) : base(options) { }
  }
} 