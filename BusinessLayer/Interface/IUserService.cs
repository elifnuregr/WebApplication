using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserService
    {
        bool CreateUser(UserDTO model);
        bool IsUserExist(string userName, string password);
        bool IsUserExistByUserName(string userName);
        UserDTO? GetUserInfoByUserName(string userName);
    }
}