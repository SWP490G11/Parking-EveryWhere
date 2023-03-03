using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class ParkingDetail { 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();
        public Car Car { get; set; }

        public Slot Slot { get; set; }

        public TimeFrame TimeFrame { get; set; }

        public DateTime ParkingDate { get; set; }

        public DateTime PickUpDate { get; set; }
        public string? Note { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }

        public double TotalPrice { 
         get { return TimeFrame.Price + Car.CarModel.Price + Slot.Price; }
        }
    }
}
