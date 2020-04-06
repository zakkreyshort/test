using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CurrentMood.Models
{
  public class CurrentMoodContextFactory : IDesignTimeDbContextFactory<CurrentMoodContext>
  {
    CurrentMoodContext IDesignTimeDbContextFactory<CurrentMoodContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<CurrentMoodContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new CurrentMoodContext(builder.Options);
    }
  }
}