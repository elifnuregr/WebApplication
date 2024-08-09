using DomainLayer.Models;

namespace DomainLayer.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        bool GetUserByUserName(string userName, string password);
    }
}
