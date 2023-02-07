using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Entities
{
    public class UserRole
    {
        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }
    }
}