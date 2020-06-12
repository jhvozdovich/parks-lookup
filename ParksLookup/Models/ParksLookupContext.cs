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
    public DbSet<Landmark> Landmarks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
          new Park { ParkId = 1, Name = "Yosemite", Classification = "National", State = "California", Hours = "24/7", PhotoUrl = "https://www.nationalgeographic.com/content/dam/expeditions/destinations/north-america/private/Yosemite/Hero-Yosemite.ngsversion.1524840074980.adapt.1900.1.jpg" },
          new Park { ParkId = 2, Name = "Gravity Falls", Classification = "State", State = "Oregon", Hours = "25/8 (if you can find it)", PhotoUrl = "https://vignette.wikia.nocookie.net/gravityfalls/images/2/22/Opening_Bigfoot.png/revision/latest?cb=20160119145704" },
          new Park { ParkId = 3, Name = "Zion", Classification = "National", State = "Utah", Hours = "24/7", PhotoUrl = "https://www.nps.gov/npgallery/GetAsset/988A495E-155D-451F-67EE640C7B3812F6/proxy/hires?" },
          new Park { ParkId = 4, Name = "Everglades", Classification = "National", State = "Florida", Hours = "24/7", PhotoUrl = "https://www.nps.gov/common/uploads/banner_image/akr/homepage/510DA558-1DD8-B71B-0BF2DBBE49B06F9F.jpg" }
          );
      builder.Entity<Landmark>()
          .HasData(
          new Landmark { LandmarkId = 1, ParkId = 1, Name = "Yosemite Valley" },
          new Landmark { LandmarkId = 2, ParkId = 1, Name = "Half Dome" },
          new Landmark { LandmarkId = 3, ParkId = 1, Name = "YosemiteFalls" },
          new Landmark { LandmarkId = 4, ParkId = 2, Name = "Mystery Shack" },
          new Landmark { LandmarkId = 5, ParkId = 2, Name = "Gravity Falls Forest" },
          new Landmark { LandmarkId = 6, ParkId = 2, Name = "Lake Gravity falls" },
          new Landmark { LandmarkId = 7, ParkId = 3, Name = "The Narrows" },
          new Landmark { LandmarkId = 8, ParkId = 3, Name = "Angels Landing" },
          new Landmark { LandmarkId = 9, ParkId = 3, Name = "Emerald Pools Trail" }
          );



    }
  }
}