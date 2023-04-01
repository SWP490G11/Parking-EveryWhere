using Back_end.Entities;

namespace Back_end.Models
{
    public class FeedbackModel
    {
        public string Content { get; set; }

        public float Rating { get; set; }

        public string FeedbackByID { get; set; }
        public ICollection<Image>? Images { get; set; }

        public Parking Parking { get; set; }

        public DateTime LastModifyAt { get; set; }
    }
}
