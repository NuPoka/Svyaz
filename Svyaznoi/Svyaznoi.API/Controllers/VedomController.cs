using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VedomController : ControllerBase
    {
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllVedom()
        {
            var context = new SVContext();
            var vedomlist = context.Vedoms.ToList();
            return Ok(vedomlist);
        }

    }
}
