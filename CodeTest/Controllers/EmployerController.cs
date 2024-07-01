using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EmployerController : ControllerBase
{
    private readonly IEmployerProvider _employerProvider;

    public EmployerController(IEmployerProvider employerProvider)
    {
        _employerProvider = employerProvider;
    }

    [HttpGet("login-logs")]
    public async Task<IEnumerable<LoginLog>> GetLoginLogs()
    {
        return await _employerProvider.GetLoginLogs();
    }

    [HttpGet("employees")]
    public async Task<IEnumerable<Employee>> GetEmployeeList()
    {
        return await _employerProvider.GetEmployeeList();
    }
}
