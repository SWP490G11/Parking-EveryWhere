using Back_end.Entities;
using System.Text.Json.Serialization;

namespace Back_end.Models
{

    public class CarModelx2
    {
        
        public string Model { get; set; }

        public string? Discript { get; set; }

  

        public DateTime? LastModifyAt { get; set; }

        [JsonIgnore]
        public Back_end.Entities.User? LastModifyBy { get; set; }
    }
}
