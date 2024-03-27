using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasurementController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<UnitOfMeasurement>>> GetAllItems()
        {
            var unitOfMeasurements = new List<UnitOfMeasurement> {
                new UnitOfMeasurement {
                    Id = 1,
                    ItemId = 1,
                    Name = "thename",
                    Status=true,
                    IsActive=true,
                    IsSmallestUnit=3
                }
            };
            return Ok(unitOfMeasurements);

        }
    }
}
