using Back_end.Common;
using Back_end.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Models
{
    public class SlotModel
    {
        
        public Guid ID { get; set; } 
       
        public CarDTO? Car { get; set; }

        public Status Status { get; set; }

        public TypeOfSlot TypeOfSlot { get; set; }

        public string Discription { get; set; }

        public ICollection<Image>? Images { get; set; }

        public double Price { get; set; }

        public Parking Parking { get; set; }

        public ICollection<ParkingDetail> ParkingDetail { get; set; }

        public DateTime LastModifyAt { get; set; }

    }
}
