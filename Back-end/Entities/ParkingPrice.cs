using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class ParkingPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }

    }
}
