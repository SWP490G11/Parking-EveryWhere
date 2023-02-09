using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class MembershipPackage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public uint Months { get; set; }

        public DateTime SubcribeAt { get; set; }

        
        public ICollection<User> SubcribeBy { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}