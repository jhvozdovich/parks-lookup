using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public Park()
    {
      this.Landmarks = new HashSet<Landmark>();
    }
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [StringLength(10)]
    public string Classification { get; set; }

    [Required]
    [StringLength(30)]
    public string State { get; set; }

    public string Hours { get; set; }

    public virtual ICollection<Landmark> Landmarks { get; set; }

    public string PhotoUrl { get; set; }
  }
}