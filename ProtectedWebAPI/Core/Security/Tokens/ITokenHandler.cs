using ProtectedWebAPI.Core.Models;
using ProtectedWebAPI.Core.Security.Tokens;

namespace ProtectedWebAPI.Core.Security.Tokens
{
    public interface ITokenHandler
    {
         AccessToken CreateAccessToken(User user);
         RefreshToken TakeRefreshToken(string token);
         void RevokeRefreshToken(string token);
    }
}