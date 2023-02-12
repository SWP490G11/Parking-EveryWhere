using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Back_end.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

        public string   UserName { get; set; }

        [JsonIgnore]
        public string HashPasword { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }

        [RegularExpression(@"^[0-9]{10,11}$")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<ParkingDetail> ParkingDetails  { get; set; }

        public ICollection<Feedback> Feedback { get; set; }

        public MembershipPackage? MembershipPackage { get; set; } = null;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; }

        public DateTime LastModifyAt { get; set; }

        
    }
}