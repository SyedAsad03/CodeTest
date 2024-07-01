public class EmployerProvider : IEmployerProvider
{
    private readonly IEmployerRepository _employerRepository;

    public EmployerProvider(IEmployerRepository employerRepository)
    {
        _employerRepository = employerRepository;
    }

    public Task<IEnumerable<LoginLog>> GetLoginLogs()
    {
        return _employerRepository.GetLoginLogs();
    }

    public Task<IEnumerable<Employee>> GetEmployeeList()
    {
        return _employerRepository.GetEmployeeList();
    }
}
