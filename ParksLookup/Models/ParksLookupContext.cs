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
          new Park { ParkId = 1, Name = "Yosemite", Classification = "National", State = "California", Hours = "27/7", PhotoUrl = "www.sample.com" }
          );
      builder.Entity<Landmark>()
          .HasData(
          new Landmark { LandmarkId = 1, ParkId = 1, Name = "Yosemite Valley" },
          new Landmark { LandmarkId = 2, ParkId = 1, Name = "Half Dome" },
          new Landmark { LandmarkId = 3, ParkId = 1, Name = "YosemiteFalls" }
          );



    }
  }
}