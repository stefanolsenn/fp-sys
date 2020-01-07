using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fp_sys_csharp_web.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var cust = FSharp_lib.Customer.create("1234567890", "Stefan Olsen");
            
            if (cust.IsOk)
            {
                return Ok(JsonConvert.SerializeObject(cust.ResultValue));
            }

            return BadRequest(cust.ErrorValue);
        }

        [HttpGet("many")]
        public IActionResult GetMany()
        {
            var custs = FSharp_lib.Customer.createMany(100);
            
            return Ok(JsonConvert.SerializeObject(custs));
        }
    }
}