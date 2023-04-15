using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Back_end.Common;

namespace Back_end.Entities
{
    public class Car 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

        public CarModel CarModel { get; set; }

        public string CarNumber { get; set; }
       
        public DateTime? LastModifyAt { get; set; }

        [InverseProperty("Cars")]
        public User CarOwner { get; set; }

        public ICollection<ParkingDetail>? ParkingDetails { get; set; } = new List<ParkingDetail>();


        public Status Status { get; set; }
    }
}