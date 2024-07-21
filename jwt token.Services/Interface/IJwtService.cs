using Microsoft.AspNetCore.Mvc;

namespace jwt_token.Services.Interface
{
    public interface IJwtService
    {
        string GenerateToken();
    }
}
