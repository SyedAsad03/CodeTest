public interface IEmployerRepository
{
    Task<IEnumerable<LoginLog>> GetLoginLogs();
    Task<IEnumerable<Employee>> GetEmployeeList();
}
