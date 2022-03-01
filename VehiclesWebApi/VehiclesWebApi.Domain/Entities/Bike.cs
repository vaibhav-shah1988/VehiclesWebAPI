using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesWebApi.Domain.Entities
{
    public class Bike
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int Speed { get; set; }
        public double MalfunctionChance { get; set; }
        public int MalfunctionOccured { get; set; }
        public int DistaanceCoveredInMiles { get; set; }
        public int FinishedRace { get; set; }
        public int RacedForHours { get; set; }
    }
}
