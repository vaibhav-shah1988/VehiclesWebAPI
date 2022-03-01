namespace VehiclesWebApi.Domain.Entities
{
    public class Car
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
