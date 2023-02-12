using System.Text.Json.Serialization;

namespace Back_end.Common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Admin,Customer,ParkingOwner
    }
}
