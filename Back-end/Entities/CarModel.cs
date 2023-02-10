using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class CarModel
    {

        public CarModel()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string  Model { get; set; }

        public string? Discript { get; set; }

        public double Price { get; set; }


        public DateTime? LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}