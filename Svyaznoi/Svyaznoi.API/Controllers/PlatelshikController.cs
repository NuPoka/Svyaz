using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlatelshikController : ControllerBase
    {
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var context = new SVContext();
            var platelshiklist = context.Platelshiks.ToList();
            return Ok(platelshiklist);
        }

    }
}
