using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Entities
{
    public class TimeFrame 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();
       
        public Parking Parking { get; set; }

        public string Name { get; set; }

        public double Start { get; set; }

        public double End { get; set; }

        public double Price { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}