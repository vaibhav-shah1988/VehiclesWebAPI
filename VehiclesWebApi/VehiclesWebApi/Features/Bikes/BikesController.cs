using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesWebApi.Domain.Entities;

namespace VehiclesWebApi.Features.Bikes
{
    [Route("api/bikes")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Bike>> GetBikes()
        {
            var bikes = new List<Bike>();
            bikes.Add(new Bike() { TeamName = "Team1", Speed = 100, MalfunctionChance = 0.3 });
            bikes.Add(new Bike() { TeamName = "Team2", Speed = 110, MalfunctionChance = 0.4 });
            bikes.Add(new Bike() { TeamName = "Team3", Speed = 95, MalfunctionChance = 0.2 });

            return Ok(bikes);
        }

        [HttpGet]
        [Route("{Id}")]
        public ActionResult<Car> GetBike(int Id)
        {
            return Ok(new Bike() { TeamName = "Team1", Speed = 100, MalfunctionChance = 0.3 });
        }



        //Create Bike
        [HttpPost]
        public ActionResult<Car> CreateBike(Bike bike)
        {
            var newBike = bike;

            return Ok(newBike);

        }


        //Update Bike
        [HttpPut]
        [Route("{Id}")]
        public ActionResult<Bike> UpdateBike(Bike bike)
        {
            var newBike = bike;

            return Ok(newBike);

        }

        //Delete Bike
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeleteBike(int Id)
        {

            return Ok("Bike Deleted");

        }
    }
}
