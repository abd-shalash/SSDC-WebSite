using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate
{
    public class LoginAuthenticationProvider : IAuthentication
    {
        private readonly EF_DBContext context = new EF_DBContext();

       
        public bool Authenticate(string Email, string password)
        {   
            try
            {
                var result = context.users.FirstOrDefault(p =>( p.password == (password) && p.email == (Email)));
               
                if (result == null)
                    return false;

  
            }
            catch (Exception e)
            {
                Console.WriteLine("Login error with ",e);
            
            }
           
            return true;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
