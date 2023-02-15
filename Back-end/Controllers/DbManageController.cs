using Back_end.Authorization;
using Back_end.Common;
using Back_end.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbManageController : ControllerBase
    {
        private readonly ILogger<DbManageController> _logger;
        private readonly ParkingDbContext _dbContext;

        public DbManageController(ILogger<DbManageController> logger, ParkingDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }


        [HttpDelete("[action]")]
        
        public async Task<IActionResult> DeleteDbAsync()
        {

            try
            {
                if (await _dbContext.Database.CanConnectAsync())
                    await _dbContext.Database.EnsureDeletedAsync();
                else BadRequest();

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Has Error: {ex}");
                return BadRequest(ex);
            }

            
            return Ok("Delete Db Success");
        }

        [HttpGet("[action]")]
        
        public async Task<IActionResult> DbInfor()
        {

            try
            {
                var connect = _dbContext.Database.GetDbConnection();
                var dbname = connect.Database;
                var can_connect = await _dbContext.Database.CanConnectAsync();

                if(can_connect) {

                    await _dbContext.Database.OpenConnectionAsync();
                    var tables = _dbContext.Database.GetDbConnection().GetSchema("Tables");

                    List<string> tableNames = new List<string>();
                    foreach (System.Data.DataRow row in tables.Rows)
                    {
                        string name = (string)row["TABLE_NAME"];
                        tableNames.Add(name);
                    }

                    var detail = new
                    {
                        Dbname = dbname,
                        Connect = connect,
                        Table = tableNames,
                    };

                    return Ok(detail);
                }
                

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Has Error: {ex}");
            }


            return Ok("Delete Db Success");
        }

        [HttpPost("[action]")]
      
        public async Task<IActionResult> Migrate()
        {

            try
            {
                if (await _dbContext.Database.CanConnectAsync())
                    await _dbContext.Database.MigrateAsync();
                else BadRequest();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Has Error: {ex}");
                return BadRequest(ex);
            }


            return Ok("Delete Db Success");
        }

    }


      
}
