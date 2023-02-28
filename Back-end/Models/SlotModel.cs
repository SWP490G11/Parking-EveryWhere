using Back_end.Common;
using Back_end.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Models
{
    public class SlotModel
    {
        
        

        public Status Status { get; set; }

        public TypeOfSlot TypeOfSlot { get; set; }

        public string Discription { get; set; }


        public double Price { get; set; }

        public string ParkingID { get; set; }

        public string CarModelID { get; set; }

        public string LastModifyByID { get; set; }
    }
}
