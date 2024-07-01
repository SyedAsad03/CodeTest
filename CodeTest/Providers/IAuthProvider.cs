using CodeTest.Models;

public interface IAuthProvider
{
    Task<User> AuthenticateUser(string username, string password);
}
