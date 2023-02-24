using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Back_end.Entities
{
    public class MembershipPackage
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public uint Months { get; set; }

        public DateTime SubcribeAt { get; set; }

        [InverseProperty("MembershipPackage")]
        [AllowNull]
        public ICollection<User>? SubcribeBy { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}