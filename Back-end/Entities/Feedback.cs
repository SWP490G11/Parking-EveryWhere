using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class Feedback  
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

        public string Content { get; set; }

        public float Rating { get; set; }

        public User FeedbackBy { get; set; }
        public ICollection<Image>? Images { get; set; }

        public Parking Parking { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}