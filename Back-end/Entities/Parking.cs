using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Entities
{
    public class Parking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]

        public ICollection<Slot> Slots { get; set; }

        public Status Status { get; set; }
        
        public string Discription { get; set; }

        public ICollection<Request>  Requests { get; set; }

        public ICollection<TimeFrame> TimeFrames { get; set; }

        public ICollection<User> Users  { get; set; }
      
        public Dashboard Dashboard { get; set; }

        public bool IsLegal { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

       

        public double LON { get; set; }

        public double LAT { get; set; }

    }
}
