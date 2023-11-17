using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [Route("counter/[controller]")]
    public class CounterController : ControllerBase
    {
        private readonly ICounterServices counterServices;

        public CounterController(ICounterServices service) 
        {
            counterServices = service;
        
        }

        [HttpGet]
        public IActionResult Get() => Ok(counterServices.Get());
      

        public IActionResult Save([FromBody] Counter counter)
        {
            counterServices.Save(counter);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Counter counter)
        {
            counterServices.Update(id, counter);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            counterServices.Delete(id);
            return Ok();
        }
    }

}