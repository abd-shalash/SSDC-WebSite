using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface IUser
    {
        IEnumerable<User> Users { get; }
        User GetSUserByID(int id);
        void InsertUser(User user);
        void DeleteUser(int UserId);
        void UpdateUser(User user);
        void Save();
        bool AddUser(User user);
    }
}
