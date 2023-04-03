using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Back_end.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

        public string UserName { get; set; }

        [JsonIgnore]
        public string HashPassword { get; set; }

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

        [RegularExpression(@"^[0-9]{12}$")]
        public string? CitizenID { get; set; }

        [Required]
        public bool IsDisable { get; set; } = false;
        [AllowNull]

        public Image? Image { get; set; }
        [ForeignKey("Image")]

        public Guid? ImageID { get; set; }

        [InverseProperty("CarOwner")]
        public ICollection<Car> Cars { get; set; } = new List<Car>();

        [AllowNull]
        public ICollection<ParkingDetail>? ParkingDetails { get; set; } = new List<ParkingDetail>();

        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        [InverseProperty("Owner")]
        [AllowNull]
        public ICollection<Parking>? Parkings { get; set; } = new List<Parking>();

        [InverseProperty("ParkingManagers")]
        public Parking? Parking { get; set; }

        [InverseProperty("SubcribeBy")]
        public MembershipPackage? MembershipPackage { get; set; }

        public ICollection<Request> Requests { get; set; } = new List<Request>();


        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; }

        public DateTime LastModifyAt { get; set; }

       
    }
}