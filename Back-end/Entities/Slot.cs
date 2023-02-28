using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Back_end.Entities
{
    public class Slot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();      
        public Status Status { get; set; }

        public TypeOfSlot TypeOfSlot { get; set; }

        public string Discription { get; set; }

        public ICollection<Image>? Images { get; set; }

        public double Price { get; set; }

        public Parking Parking { get; set; }

        public CarModel CarModel { get; set; }

        public ICollection<ParkingDetail>? ParkingDetail { get; set; }

        public DateTime LastModifyAt { get; set; }

        public User? LastModifyBy { get; set; }


    }
}