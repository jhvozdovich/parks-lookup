using ParksLookup.Models;
using System.Collections.Generic;

namespace ParksLookup.Data
{

  public static class DbInitializer
  {
    public static void Initialize(ParksLookupContext context)
    {
      var landmarks = new List<Landmark>
      {
        new Landmark { Name = "Yosemite Valley" },
        new Landmark { Name = "Half Dome" },
        new Landmark { Name = "YosemiteFalls" },
        new Landmark { Name = "Mystery Shack" },
        new Landmark { Name = "Gravity Falls Forest" },
        new Landmark { Name = "Lake Gravity falls" },
        new Landmark { Name = "The Narrows" },
        new Landmark { Name = "Angels Landing" },
        new Landmark { Name = "Emerald Pools Trail" }
      };

      landmarks.ForEach(landmark => context.Landmarks.Add(landmark));
      context.SaveChanges();

      var parks = new List<Park>
      {
        new Park { Name = "Yosemite", Classification = "National", State = "California", Hours = "24/7", PhotoUrl = "https://www.nationalgeographic.com/content/dam/expeditions/destinations/north-america/private/Yosemite/Hero-Yosemite.ngsversion.1524840074980.adapt.1900.1.jpg" },
        new Park { Name = "Gravity Falls", Classification = "State", State = "Oregon", Hours = "25/8 (if you can find it)", PhotoUrl = "https://vignette.wikia.nocookie.net/gravityfalls/images/2/22/Opening_Bigfoot.png/revision/latest?cb=20160119145704" },
        new Park { Name = "Zion", Classification = "National", State = "Utah", Hours = "24/7", PhotoUrl = "https://www.nps.gov/npgallery/GetAsset/988A495E-155D-451F-67EE640C7B3812F6/proxy/hires?" },
        new Park { Name = "Everglades", Classification = "National", State = "Florida", Hours = "24/7", PhotoUrl = "https://www.nps.gov/common/uploads/banner_image/akr/homepage/510DA558-1DD8-B71B-0BF2DBBE49B06F9F.jpg" }
      };
      parks.ForEach(park => context.Parks.Add(park));
      context.SaveChanges();

      parks[0].Landmarks.Add(landmarks[0]);
      parks[0].Landmarks.Add(landmarks[1]);
      parks[0].Landmarks.Add(landmarks[2]);
      parks[1].Landmarks.Add(landmarks[3]);
      parks[1].Landmarks.Add(landmarks[4]);
      parks[1].Landmarks.Add(landmarks[5]);
      parks[2].Landmarks.Add(landmarks[6]);
      parks[2].Landmarks.Add(landmarks[7]);
      parks[2].Landmarks.Add(landmarks[8]);
      context.SaveChanges();
    }
  }
}