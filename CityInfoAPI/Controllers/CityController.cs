using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return  Ok(DataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = DataStore.Current.Cities.FirstOrDefault(x => x.Id == id);
            if(cityToReturn==null)
            {
                return NotFound();
            }
            return  Ok(cityToReturn);
        }
    }
}