using jwt_token.Services.Interface;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{   
    private readonly IJwtService _jwtService;
    public AuthController(IJwtService jwtService)
    {       
        _jwtService = jwtService;
    }

    [HttpPost("token")]
    public IActionResult GenerateToken()
    {
            var token = _jwtService.GenerateToken();
            return Ok(new { Token = token });        
    }
}
