using Back_end.Common;

namespace Back_end.Models
{
    public class UpdateRequestModel
    {
        public string Note { get; set; }


        public string ParkingID { get; set; }

        public Status Status { get; set; }
    }
}
