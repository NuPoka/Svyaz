using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VedomController : ControllerBase
    {
        private readonly IContext context1;
        public VedomController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllVedom()
        {
            var vedomlist = context1.Vedoms.ToList();
            return Ok(vedomlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var vedomlist = context1.Vedoms.FirstOrDefault(x => x.Id == id);
            return Ok(vedomlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group4 = context1.Vedoms.FirstOrDefault(x => x.Id == id);
            if (group4 != null)
            {
                context1.Vedoms.Remove(group4);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Vedom model)
        {
            var item4 = new Vedom
            {
                Id = Guid.NewGuid(),
                TovarId = Guid.NewGuid(),
                PostavshikId = Guid.NewGuid(),
                PlatelshikId = Guid.NewGuid(),
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Vedoms.Add(item4);
            context1.SaveChanges();
            return Ok(item4);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Vedom model)
        {
            var group4 = context1.Vedoms.FirstOrDefault(x => x.Id == Id);
            if (group4 != null)
            {
                return NotFound();
            }
            group4.TovarId = model.TovarId;
            group4.PostavshikId = model.PostavshikId;
            group4.PlatelshikId= model.PlatelshikId;
            group4.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group4);
        }
    }
}
