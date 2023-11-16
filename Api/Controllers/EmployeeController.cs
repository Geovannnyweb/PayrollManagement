
using Application.Interfaces;
using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("employee/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
    
        public EmployeeController(IEmployeeService service)
        {
            employeeService = service;
        
        }
        [HttpGet]
        public IActionResult Get() => Ok(employeeService.Get());

        [HttpPost]
        public IActionResult Save([FromBody] Employee employee)
        {

            employeeService.Save(employee);
            return Ok();

        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Employee employee)
        {
            employeeService.Update(id, employee);
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            employeeService.Delete(id);
            return Ok();
        }

    }
}
