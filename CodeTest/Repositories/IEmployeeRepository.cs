public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task AddEmployee(Employee employee);
}
