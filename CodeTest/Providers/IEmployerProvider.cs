public interface IEmployerProvider
{
    Task<IEnumerable<LoginLog>> GetLoginLogs();
    Task<IEnumerable<Employee>> GetEmployeeList();
}
