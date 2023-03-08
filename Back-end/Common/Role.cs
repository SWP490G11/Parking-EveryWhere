﻿using System.Text.Json.Serialization;

namespace Back_end.Common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Admin=-772000,Customer=1,ParkingOwner=2,ParkingManager=3
    }
}
