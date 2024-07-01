using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthProvider _authProvider;

    public AuthController(IAuthProvider authProvider)
    {
        _authProvider = authProvider;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        Console.WriteLine($"Attempting login for user: {request.Username}");
        var user = await _authProvider.AuthenticateUser(request.Username, request.Password);
        if (user != null)
        {
            Console.WriteLine($"Login successful for user: {request.Username}");
            return Ok(user);
        }

        Console.WriteLine($"Unauthorized login attempt for user: {request.Username}");
        return Unauthorized();
    }
}
