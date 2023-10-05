using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthFilterNetCore.Controllers
{
    [CustomAuthorizationFilter]
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {

        public IActionResult GetData()
        {
            return Ok("Dev Tech Mind");
        }
    }
}
