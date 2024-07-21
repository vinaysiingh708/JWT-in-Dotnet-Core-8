using jwt_token.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
