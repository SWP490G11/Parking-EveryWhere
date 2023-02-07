using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public CarModel CarModel { get; set; }

        public string CarNumber { get; set; }
       
        public DateTime? LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}