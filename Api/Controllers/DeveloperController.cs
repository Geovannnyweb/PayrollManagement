using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("developer/[controller]")]
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperService developerService;
        public DeveloperController(IDeveloperService service)
        { 
            developerService = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(developerService.Get());

        [HttpPost]
        public IActionResult Save([FromBody] Developer developer)
        {
            developerService.Save(developer);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Developer developer)
        {
            developerService.Update(id, developer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) 
        {
            developerService.Delete(id);
            return Ok();
        }


    }
}
