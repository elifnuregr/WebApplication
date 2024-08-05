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
        bool CreateUser(User model);
        bool IsUserExist(object userName, object password);
    }
}
