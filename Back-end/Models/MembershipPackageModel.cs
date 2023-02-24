

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Back_end.Models
{
   
    public class MembershipPackageModel
    {
        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public uint Months { get; set; }

        
        public DateTime SubcribeAt { get; set; }

        [JsonIgnore]
        [AllowNull]
        public ICollection<Back_end.Entities.User>? SubcribeBy { get; set; }

        [JsonIgnore]
        public DateTime LastModifyAt { get; set; }
    }
}
