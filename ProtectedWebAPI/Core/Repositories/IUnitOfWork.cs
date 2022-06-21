using System.Threading.Tasks;

namespace ProtectedWebAPI.Core.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}