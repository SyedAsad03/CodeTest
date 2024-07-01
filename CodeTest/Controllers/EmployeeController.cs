using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeProvider _employeeProvider;

    public EmployeeController(IEmployeeProvider employeeProvider)
    {
        _employeeProvider = employeeProvider;
    }

    [HttpGet]
    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await _employeeProvider.GetEmployees();
    }

    [HttpGet("{id}")]
    public async Task<Employee> GetEmployeeById(int id)
    {
        return await _employeeProvider.GetEmployeeById(id);
    }

    [HttpPost]
    public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
    {
        await _employeeProvider.AddEmployee(employee);
        return Ok();
    }
}
