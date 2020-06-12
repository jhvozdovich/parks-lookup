using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;
using System;
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

    // GET api/landmarks/GetRandom
    [HttpGet]
    [Route("GetRandom")]
    public ActionResult<Landmark> GetRandom()
    {
      List<Landmark> landmarks = _db.Landmarks.ToList();
      var random = new Random();
      int num = random.Next(landmarks.Count - 1);
      return landmarks[num];
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

    // // PUT api/landmarks/2
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] Landmark landmark)
    // {
    //   landmark.LandmarkId = id;
    //   if (landmark.ParkId != 0)
    //   {
    //     Console.WriteLine("__________________________________________________________________");
    //     Console.WriteLine("I GOT IN THE IF STATEMENT");
    //     Park park = _db.Parks.FirstOrDefault(entry => entry.ParkId == landmark.ParkId);
    //     Console.WriteLine("__________________________________________________________________");
    //     Console.WriteLine("HERE IS THE PARK");
    //     Console.WriteLine(park.Name);
    //     park.Landmarks.Add(landmark);
    //     landmark.Park = park;
    //     Console.WriteLine("__________________________________________________________________");
    //     Console.WriteLine("ADDED PARK???");
    //     Console.WriteLine(landmark.Park.Name);
    //     _db.Entry(park).State = EntityState.Modified;
    //   }
    //   _db.Entry(landmark).State = EntityState.Modified;
    //   _db.SaveChanges();
    // }

    // PUT api/landmarks/2
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Landmark landmark)
    {
      var originalPark = _db.Parks
        .Where(park => park.ParkId == landmark.ParkId)
        .Include(landmarks => landmarks.Landmarks)
        .SingleOrDefault();

      var parkEntry = _db.Entry(originalPark);
      parkEntry.CurrentValues.SetValues(landmark.Park);


      foreach (Landmark oldLandmark in landmark.Park.Landmarks)
      {
        var originalLandmark = originalPark.Landmarks
          .Where(x => x.LandmarkId == oldLandmark.LandmarkId && x.LandmarkId != 0)
          .SingleOrDefault();

        if (originalLandmark != null)
        {
          var landmarkEntry = _db.Entry(originalLandmark);
          landmarkEntry.CurrentValues.SetValues(oldLandmark);
        }
        else
        {
          oldLandmark.LandmarkId = 0;
          originalPark.Landmarks.Add(landmark);
        }
      }
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