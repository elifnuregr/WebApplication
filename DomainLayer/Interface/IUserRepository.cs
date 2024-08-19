using DomainLayer.Models;

namespace DomainLayer.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        bool GetUserByUserName(string userName);
        bool GetUserByUserNameAndPassword(string userName, string password);
    }
}