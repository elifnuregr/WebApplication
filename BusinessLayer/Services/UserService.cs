using BusinessLayer.Interface;
using BusinessLayer.Models;
using DomainLayer.Interface;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public bool CreateUser(UserDTO model)
        {
            bool result = false;
            try
            {
                if (model != null)
                {
                    //Db model ile dto eşitle
                    User user = new User();
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.Password = model.Password;

                    //kullanıcı ekle
                    _userRepository.Add(user);

                    result = true;
                }
            }
            catch
            {
                throw new Exception("Beklenmedik bir hata oluştu.");
            }

            return result;
        }

        public bool IsUserExist(string userName, string password)
        {
            bool result = false;
            try
            {
                result = _userRepository.GetUserByUserNameAndPassword(userName, password);
            }
            catch {
                throw new Exception("Beklenmedik bir hata oluştu.");
            }
            
            return result;
        }

        public bool IsUserExistByUserName(string userName)
        {
            bool result = false;
            try
            {
                result = _userRepository.GetUserByUserName(userName);
            }
            catch
            {
                throw new Exception("Beklenmedik bir hata oluştu.");
            }

            return result;
        }
    }
}