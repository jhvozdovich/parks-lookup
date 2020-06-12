using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;
using System.Collections.Generic;
using System.Linq;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LandmarksController : ControllerBase
  {
    private ParksLookupContext _db;

    public LandmarksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET api/landmarks
    [HttpGet]
    public ActionResult<IEnumerable<Landmark>> Get(string name)
    {
      var query = _db.Landmarks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      return query.ToList();
    }

    // GET api/landmarks/2
    [HttpGet("{id}")]
    public ActionResult<Landmark> Get(int id)
    {
      return _db.Landmarks.FirstOrDefault(entry => entry.LandmarkId == id);
    }

    // POST api/landmarks
    [HttpPost]
    public void Post([FromBody] Landmark landmark)
    {
      if (landmark.ParkId != 0)
      {
        Park park = _db.Parks.FirstOrDefault(entry => entry.ParkId == landmark.ParkId);
        park.Landmarks.Add(landmark);
        landmark.Park = park;
      }
      _db.Landmarks.Add(landmark);
      _db.SaveChanges();
    }

    // PUT api/landmarks/2
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Landmark landmark)
    {
      landmark.LandmarkId = id;
      _db.Entry(landmark).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/landmarks/2
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var landmarkToDelete = _db.Landmarks.FirstOrDefault(entry => entry.LandmarkId == id);
      _db.Landmarks.Remove(landmarkToDelete);
      _db.SaveChanges();
    }
  }
}