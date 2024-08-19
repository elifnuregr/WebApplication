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

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
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

        public UserDTO? GetUserInfoByUserName(string userName)
        {
            try
            {
                if (!string.IsNullOrEmpty(userName))
                {
                    var data = _userRepository.GetUserInfoByUserName(userName);
                    if (data != null)
                    {
                        UserDTO user = new UserDTO();
                        user.Id = data.Id;
                        user.UserName = data.UserName;
                        user.FirstName = data.FirstName;
                        user.LastName = data.LastName;

                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                throw new Exception("Kullanıcı bilgisi bulunamadı.");
            }

            return null;   
        }

        public bool IsUserExist(string userName, string password)
        {
            bool result = false;
            try
            {
                result = _userRepository.GetUserByUserNameAndPassword(userName, password);
            }
            catch
            {
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