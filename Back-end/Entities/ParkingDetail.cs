using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class ParkingDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public Car Car { get; set; }

        public Slot Slot { get; set; }

        public TimeFrame TimeFrame { get; set; }

        public string? Note { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}
