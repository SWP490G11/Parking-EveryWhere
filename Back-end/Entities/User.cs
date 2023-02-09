using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public string   UserName { get; set; }

        public string HashPasword { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<ParkingDetail> ParkingDetails  { get; set; }

        public ICollection<Feedback> Feedback { get; set; }

        public MembershipPackage? MembershipPackage { get; set; } = null;

        public Role Role { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}