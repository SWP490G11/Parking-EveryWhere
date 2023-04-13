using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end.Entities
{
    public class CarModel 
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; } = Guid.NewGuid();
        public string  Model { get; set; }

        public string? Discript { get; set; }

 


        public DateTime? LastModifyAt { get; set; }

        [JsonIgnore]
        public User? LastModifyBy { get; set; }
    }
}