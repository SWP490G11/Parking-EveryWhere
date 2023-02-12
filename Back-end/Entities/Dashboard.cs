using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class Dashboard 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();
        public double Revenue { get; set; }

        public  long NumberOfMember { get; set; }

        
        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }
    }
}