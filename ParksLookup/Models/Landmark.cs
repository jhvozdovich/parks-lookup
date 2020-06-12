using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Landmark
  {
    public int LandmarkId { get; set; }
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    public virtual Park Park { get; set; }
  }
}