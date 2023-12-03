using EmployeeBL.Interfaces;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpBL _empBL;
        public EmployeeController(IEmpBL empBL)
        {
            this._empBL = empBL;   
        }
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
           return Ok(await _empBL.GetEmps());
        }
      
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody]List<Employee> newEmps)
        {
           return Ok(await _empBL.AddEmp(newEmps[0]));
        }
    }
}
