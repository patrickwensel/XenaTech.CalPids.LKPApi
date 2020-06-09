using Microsoft.AspNetCore.Mvc;
using XenaTech.CalPids.LKPApi.Filters;

namespace XenaTech.CalPids.LKPApi.Controllers.V1
{
    [ApiKeyAuth]
    public class SecretController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            return Ok("I have no secrets");
        }
    }
}