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

        public bool Authenticate(string username, string password)
        {
            try
            {
                var result = context.People.FirstOrDefault(p => p.Username == string.Concat(username) && p.Password == string.Concat(password));

                if (result == null)
                    return false;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool Logout()
        {
            return true;
        }
    }
}
