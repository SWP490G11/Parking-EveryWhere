using Back_end.Entities;

namespace Back_end.Models
{
    public class TimeFrameModel
    {
        public string ParkingID { get; set; }
        public string Name { get; set; }

        public double Start { get; set; }

        public double End { get; set; }

        public double Price { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}
