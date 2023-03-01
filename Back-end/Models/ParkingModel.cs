using Back_end.Common;
using Back_end.Entities;
using System.Text.Json.Serialization;

namespace Back_end.Models
{
    public class ParkingModel
    {
        public string ParkingName { get; set; }
        public Status Status { get; set; }

        public string Discription { get; set; }

        public bool IsLegal { get; set; }

        public DateTime LastModifyAt { get; set; }

        public double LON { get; set; }

        public double LAT { get; set; }

        public string? AddressDetail { get; set; }
    }
}
