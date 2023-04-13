using Back_end.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Back_end.Entities
{
    public class Parking {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();

       

        public ICollection<Slot>? Slots { get; set; } = new List<Slot>();

        public Status Status { get; set; }

        public string ParkingName { get; set; }

        public string Discription { get; set; }

        public ICollection<Request>? Requests { get; set; } = new List<Request>();
       
     

        [InverseProperty("Parking")]
        public ICollection<User>? ParkingManagers { get; set; } = new List<User>();

        public Dashboard? Dashboard { get; set; }

        public bool IsLegal { get; set; }

        public DateTime LastModifyAt { get; set; }


        [InverseProperty("Parkings")]
        public User Owner { get; set; }



        public ICollection<Image>? Images { get; set; } = new List<Image>();


        public ICollection<Feedback>? Feedbacks { get; set; } = new List<Feedback>();



        public double LON { get; set; }

        public double LAT { get; set; }

        public string? AddressDetail { get; set; }

    }
}
