using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class Image 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

        public string URL { get; set; }

        public User User { get; set; }
        public Parking Parking { get; set; }

        public Feedback? Feedback { get; set; }
    }
}