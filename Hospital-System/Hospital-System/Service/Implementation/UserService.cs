using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;
using Hospital_System.View.Util;

namespace Hospital_System.Service.Implementation
{
    class UserService : IUserService
    {
        public UserModel Login(LoginModel loginModel)
        {
            //User user = UserRepository.GetUser(loginModel.Username)
            UserModel userModel=null;
            // if (userModel!=null)
            // {
            userModel = new UserModel();
                userModel.Id = 77;
                userModel.Name = "John";
                // userModel.Id = user.Id;
                // userModel.Name = user.Name;
                //if(user.Role=Admin){
                userModel.Role = UserRoleNameProvider.Admin;
                //}
                //else
                //{
                userModel.Role = UserRoleNameProvider.Doctor;
                //}
            // }

            return userModel;
        }

        
    }
}
