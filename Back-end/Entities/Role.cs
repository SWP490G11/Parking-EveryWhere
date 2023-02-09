using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string RoleName { get; set; }

        public DateTime? LastModifyAt { get; set; }


        public ICollection<User> Users;
    }
}