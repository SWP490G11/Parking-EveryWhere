using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Entities
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public long LNT { get; set; }

        public long LAT { get; set; }

        public string Address { get; set; }
 
        public User User { get; set; }

        [ForeignKey("User")]
        public Guid UserID { get; set; }


        public Parking Parking { get; set; }

        [ForeignKey("Parking")]
        public Guid ParkingID { get; set; }
    }
}