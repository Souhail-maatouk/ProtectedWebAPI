using ProtectedWebAPI.Core.Models;
using ProtectedWebAPI.Core.Services.Communication;
using System.Threading.Tasks;

namespace ProtectedWebAPI.Core.Services
{
    public interface IUserService
    {
         Task<CreateUserResponse> CreateUserAsync(User user, params ApplicationRole[] userRoles);
         Task<User> FindByEmailAsync(string email);
    }
}