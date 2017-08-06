
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Abstract;
using SSDC_WebSite.Models;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace ClassLibrary.Concrate
{
    public class EF_User : IUser
    {
        private  EF_DBContext Context;

        public IEnumerable<User> Users { get { return Context.Users; } }

        public EF_User(EF_DBContext context)
        {
            this.Context = context;
        }

        public User GetSUserByID(int id)
        {
            return Context.Users.Find(id);
        }

        public void InsertUser(User user)
        {
            Context.Users.Add(user);
        }

        public void DeleteUser(int studentID)
        {
            User user = Context.Users.Find(studentID);
            Context.Users.Remove(user);
        }

        public void UpdateUser(User newuser)
        {
            if (newuser.user_id == 0)
            {
                Context.Users.Add(newuser);
            }
            else
            {
                User userupdate = Context.Users.Find(newuser.user_id);
                if (userupdate!=null)
                {
                    userupdate.first_name = newuser.first_name;
                    userupdate.last_name = newuser.last_name;
                    userupdate.userGender = newuser.userGender;
                    userupdate.email = newuser.email;
                    userupdate.mobile_number = newuser.mobile_number;
                    userupdate.password = newuser.password;
                    userupdate.work_number = newuser.work_number;
                    
                }
            }
            Context.SaveChanges();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public bool AddUser(User user)
        {
            Context.Users.Add(user);
            return true;
        }
    }
}
