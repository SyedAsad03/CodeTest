using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly DapperContext _context;

    public EmployeeRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        var query = "SELECT * FROM Employees";
        using (var connection = _context.CreateConnection())
        {
            return await connection.QueryAsync<Employee>(query);
        }
    }

    public async Task<Employee> GetEmployeeById(int id)
    {
        var query = "SELECT * FROM Employees WHERE EmployeeId = @Id";
        using (var connection = _context.CreateConnection())
        {
            return await connection.QuerySingleOrDefaultAsync<Employee>(query, new { Id = id });
        }
    }

    public async Task AddEmployee(Employee employee)
    {
        var query = "INSERT INTO Employees (EmployeeName, EmployeeDescription, EmployeeAge, EmployeeGender) VALUES (@EmployeeName, @EmployeeDescription, @EmployeeAge, @EmployeeGender)";
        using (var connection = _context.CreateConnection())
        {
            await connection.ExecuteAsync(query, employee);
        }
    }
}
