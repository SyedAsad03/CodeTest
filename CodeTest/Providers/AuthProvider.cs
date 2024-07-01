using CodeTest.Models;

public class AuthProvider : IAuthProvider
{
    private readonly IAuthRepository _authRepository;

    public AuthProvider(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public Task<User> AuthenticateUser(string username, string password)
    {
        return _authRepository.AuthenticateUser(username, password);
    }
}
