using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EmployerRepository : IEmployerRepository
{
    private readonly DapperContext _context;

    public EmployerRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LoginLog>> GetLoginLogs()
    {
        var query = "SELECT * FROM LoginLogs";
        using (var connection = _context.CreateConnection())
        {
            return await connection.QueryAsync<LoginLog>(query);
        }
    }

    public async Task<IEnumerable<Employee>> GetEmployeeList()
    {
        var query = "SELECT EmployeeId, EmployeeName FROM Employees";
        using (var connection = _context.CreateConnection())
        {
            return await connection.QueryAsync<Employee>(query);
        }
    }
}
