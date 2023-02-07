using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string  Model { get; set; }

        public string? Discript { get; set; }

        public ParkingPrice ParkingPrice { get; set; }

        [ForeignKey("ParkingPrice")]
        public Guid ParkingPriceID { get; set; }

        public DateTime? LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}