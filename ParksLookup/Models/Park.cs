using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [StringLength(8)]
    public string Classification { get; set; }

    [Required]
    [StringLength(15)]
    public string State { get; set; }

    public string Hours { get; set; }

    public List<string> Landmarks { get; set; }

    public string PhotoUrl { get; set; }
  }
}