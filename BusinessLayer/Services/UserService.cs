using BusinessLayer.Interface;
using BusinessLayer.Models;
using DomainLayer.Interface;
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
        public bool CreateUser(User model)
        {
            bool result = false;

            if (model != null)
            {
                //Db model ile dto eşitle

                //kullanıcı ekle
                //_userRepository.Create();

                result = true;
            }

            return result;
        }

        public bool IsUserExist(string userName, string password)
        {
            bool result = false;
            try
            {
                result = _userRepository.GetUserByUserName(userName, password);
            }
            catch {
                throw new Exception("Beklenmedik bir hata oluştu.");
            }
            
            return result;
        }
    }
}