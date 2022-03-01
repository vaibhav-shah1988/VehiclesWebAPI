using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VehiclesWebApi.Domain.Entities;

namespace VehiclesWebApi.Features.Cars
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Car>> GetCars()
        {
            var cars = new List<Car>();
            cars.Add(new Car() { TeamName = "Team1", Speed = 100, MalfunctionChance = 0.3 });
            cars.Add(new Car() { TeamName = "Team2", Speed = 110, MalfunctionChance = 0.4 });
            cars.Add(new Car() { TeamName = "Team3", Speed = 95, MalfunctionChance = 0.2 });

            return Ok(cars);
        }
    }
}
