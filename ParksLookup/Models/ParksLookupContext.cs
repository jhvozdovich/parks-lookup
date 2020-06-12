using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
          new Park { ParkID = 1, Name = "Yosemite", Classification = "National", State = "California", Hours = "27/7", Landmarks = { "Yosemite Valley", "Half Dome", "Yosemite Falls" }, PhotoUrl = "www.sample.com" }
          );
    }
  }
}