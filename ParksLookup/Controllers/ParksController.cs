using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParksLookup.Models;
using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksLookupContext _db;

    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string classification, string state)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      else if (classification != null)
      {
        query = query.Where(entry => entry.Classification.Contains(classification));
      }
      else if (state != null)
      {
        query = query.Where(entry => entry.State.Contains(state));
      }

      return query.ToList();
    }
  }
}