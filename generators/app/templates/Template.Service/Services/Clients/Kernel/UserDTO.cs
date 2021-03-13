using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Services.DTOs.Clients.Kernel
{
   public  class UserDTO 
    {

     

        public class  UserLogin
        {
 
            public string UserName { get; set; }

 
            public string Password { get; set; }

 
            public int ApplicationID { get; set; }

            public override string ToString()
            {
                return "LoginDTO{" +
                       $"Username='{UserName}'" +
                       $", Password='{Password}'" +
                       "}";
            }

        }

        public class UserLoginResponse
        {

            public string id_token { get; set; }


            public string refresh_token { get; set; }


            public int ExpireIn { get; set; }



        }
        public class UpdateUserMobile
        {
            public string NationalCode { get; set; }
            public string Mobile { get; set; }
        }
    }
}
