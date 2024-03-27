using WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetAllItems ()
        {
            var items = new List<Item> {
                new Item {
                    Id = 1,
                    Code = "code",
                    Description = "description",
                    Status=true,
                    IsActive=true


                }
            };
            return Ok(items);

        }

    }
}
