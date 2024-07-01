using CodeTest.Models;
using Dapper;

public class AuthRepository : IAuthRepository
{
    private readonly DapperContext _context;

    public AuthRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<User> AuthenticateUser(string username, string password)
    {
        var query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
        using (var connection = _context.CreateConnection())
        {
            return await connection.QuerySingleOrDefaultAsync<User>(query, new { Username = username, Password = password });
        }
    }
}
