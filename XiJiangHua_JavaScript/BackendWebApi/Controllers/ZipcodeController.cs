using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackendWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipcodeController : ControllerBase
    {

        [HttpPost]
        public IActionResult PostZipcode([FromForm] string city, [FromForm] string district, [FromForm] string zipcode)
        {
            return new ObjectResult(new { StatusCode = 201, City = city, District = district, Zipcode = zipcode, Message = "這是從後端Web API回傳的資料" });
        }
    }
}