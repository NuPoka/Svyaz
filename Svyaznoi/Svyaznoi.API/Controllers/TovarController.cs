using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TovarController : ControllerBase
    {
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllTovar()
        {
            var context = new SVContext();
            var tovarlist = context.Tovars.ToList();
            return Ok(tovarlist);
        }

    }
}
