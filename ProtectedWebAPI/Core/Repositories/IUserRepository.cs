using ProtectedWebAPI.Core.Models;
using System.Threading.Tasks;

namespace ProtectedWebAPI.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}