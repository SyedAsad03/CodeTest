public class EmployeeProvider : IEmployeeProvider
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeProvider(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public Task<IEnumerable<Employee>> GetEmployees()
    {
        return _employeeRepository.GetEmployees();
    }

    public Task<Employee> GetEmployeeById(int id)
    {
        return _employeeRepository.GetEmployeeById(id);
    }

    public Task AddEmployee(Employee employee)
    {
        return _employeeRepository.AddEmployee(employee);
    }
}
