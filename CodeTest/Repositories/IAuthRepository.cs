using CodeTest.Models;

public interface IAuthRepository
{
    Task<User> AuthenticateUser(string username, string password);
}
