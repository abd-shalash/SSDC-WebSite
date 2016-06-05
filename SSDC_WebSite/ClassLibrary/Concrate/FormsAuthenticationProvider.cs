using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate
{
    public class FormsAuthenticationProvider : IAuthentication
    {
        private readonly EF_DBContext context = new EF_DBContext();

        public bool Authenticate(string username, string password)
        {
            var result = context.People.FirstOrDefault(p => p.Username == username && p.Password == password);

            if (result == null)
                return false;
            return true;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
