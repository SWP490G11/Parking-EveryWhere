using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Helper.Seeding
{
    public static class ParkingSeed
    {
        public static ICollection<Parking> Seed { get
            {
                return new List<Parking>()
                {
                      /*new Parking(){
                           ParkingName = "Parking 1", Discription ="Test Data",LAT = 20.991150, LON=105.519148, Status = Status.Available, IsLegal = true,
                           AddressDetail ="Test Adresss",Owner = UserSeed.Seed.ToList()[0],
                        },
                         new Parking(){
                           ParkingName = "Parking 2", Discription ="Test Data",LAT = 20.989728, LON=105.516648, Status = Status.Available, IsLegal = true,
                           AddressDetail ="Test Adresss",Owner = UserSeed.Seed.ToList()[0],
                        },
                          new Parking(){
                           ParkingName = "Parking 3", Discription ="Test Data",LAT = 20.992132, LON=105.514524, Status = Status.Available, IsLegal = true,
                           AddressDetail ="Test Adresss",Owner = UserSeed.Seed.ToList()[0],
                        },*/
                }; 
            }
                
                 }
    }
}
