using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface IuserRepo
    {
        IEnumerable<user> users { get; }
         user GetSUserByID(int id);

         void InsertUser(user student);

         void DeleteUser(int studentID);
         void UpdateUser(user newuser);

         void Save();

         bool addUser(user user);
    }
}
