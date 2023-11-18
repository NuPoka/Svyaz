using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostavshikController : ControllerBase
    {
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var context = new SVContext();
            var postavshiklist = context.Postavshiks.ToList();
            return Ok(postavshiklist);
        }

    }
}
