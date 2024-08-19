using DomainLayer.Models;
using DomainLayer.Interface;
using DataLayer.Context;

namespace DataLayer.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(StajProjeContext context) : base(context)
        {
        }

        public bool GetUserByUserName(string userName)
        {
            return _context.Users.Any(x => x.UserName == userName);
        }
        public bool GetUserByUserNameAndPassword(string userName, string password)
        {
            return _context.Users.Any(x => x.UserName == userName && x.Password == password);
        }
    }
}