using Back_end.Entities;

namespace Back_end.Models
{
    public class TimeFrameModel
    {
        public Parking Parkings { get; set; }

        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public double Price { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}
