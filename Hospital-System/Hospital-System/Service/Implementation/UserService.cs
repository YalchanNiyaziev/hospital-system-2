using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;
using Hospital_System.Data.Repository;
using Hospital_System.Data.Repository.Implementation;
using Hospital_System.View.Model;
using Hospital_System.View.Util;

namespace Hospital_System.Service.Implementation
{
    class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        public UserModel Login(LoginModel loginModel)
        {
            User user = userRepository.GetUser(loginModel.Username, loginModel.Password);
            UserModel userModel = null;
            if (user != null)
            {
                userModel = new UserModel();
                userModel.Name = user.Name;
                userModel.Id = user.Id;
                userModel.Role = user.Role.ToString();
            }
            return userModel;
        }
    }
}