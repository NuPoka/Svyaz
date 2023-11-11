using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NakladnayaController : ControllerBase
    {
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllNakladnaya() 
        {
            var context = new SVContext();
            var nakladnayalist = context.Nakladnayas.ToList();
            return Ok(nakladnayalist);
        }
    }
}
