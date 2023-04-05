using Back_end.Entities;

namespace Back_end.Models
{
    public class FeedbackModel
    {
        public string Content { get; set; }

        public float Rating { get; set; }
        public List<string> ImageURLs { get; set; }

        public string ParkingID { get; set; }

    }
}
