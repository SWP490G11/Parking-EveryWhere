using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingIncomeController : ControllerBase
    {
        private readonly ParkingRespository _reporsitory;

        public ParkingIncomeController(ParkingRespository reporsitory)
        {
            _reporsitory = reporsitory;
        }

        [HttpGet("parking-income-by-day/{parkingId}")]
        public IActionResult TotalIncomeOfParkingByDay(string id)
        {
            var parking = _reporsitory.GetAsync(id);
            var currentday = DateTime.Now.Day ;
            var totalIncomebyDay = parking.Slots.SelectMany(s => s.ParkingDetail).Where(pd =>
            {
                var pickupday = pd.PickUpDate == null ? pd.PickUpDate.Value.Day :pd.ParkingDate.Day;
                return pickupday == currentday;
            }).Sum(pd=>pd.TotalPrice);
            return Ok(totalIncomebyDay);
        }


        [HttpGet("parking-income-by-month/{parkingId}")]
        public IActionResult TotalIncomeOfParkingByMonth(string id)
        {
            var parking = _reporsitory.GetAsync(id);
            var currentday = DateTime.Now.Day;
            var totalIncomebyMonth = parking.Slots.SelectMany(s => s.ParkingDetail).Where(pd =>
            {
                var pickupday = pd.PickUpDate == null ? pd.PickUpDate.Value.Day : pd.ParkingDate.Day;
                return pickupday == currentday;
            }).Sum(pd => pd.TotalPrice);
            return Ok(totalIncomebyMonth);
        }

        [HttpGet("parking-income-by-year/{parkingId}")]
        public IActionResult TotalIncomeOfParkingByYear(string id)
        {
            var parking = _reporsitory.GetAsync(id);
            var currentday = DateTime.Now.Day;
            var totalIncomebyYear = parking.Slots.SelectMany(s => s.ParkingDetail).Where(pd =>
            {
                var pickupday = pd.PickUpDate == null ? pd.PickUpDate.Value.Day : pd.ParkingDate.Day;
                return pickupday == currentday;
            }).Sum(pd => pd.TotalPrice);
            return Ok(totalIncomebyYear);
        }

    }
}
