

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
    }
}
