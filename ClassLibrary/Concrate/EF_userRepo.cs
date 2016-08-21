
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
    public class EF_userRepo : IuserRepo
    {
        private  EF_DBContext context;
        public EF_userRepo(EF_DBContext context)
        {
            this.context = context;
        }
        public IEnumerable<user> users  {   get{return context.users; } }
        public user GetSUserByID(int id)
        {
            return context.users.Find(id);
        }

        public void InsertUser(user student)
        {
            context.users.Add(student);
        }

        public void DeleteUser(int studentID)
        {
            user user = context.users.Find(studentID);
            context.users.Remove(user);
        }
        public void UpdateUser(user newuser)
        {
            // context.Entry(newuser).State = EntityState.Modified;
            if (newuser.user_id ==0)
            {
                context.users.Add(newuser);
            }
            else
            {
                user userupdate = context.users.Find(newuser.user_id);
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
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public bool addUser(user user)
        {
            context.users.Add(user);
            return true;
        }
    }
}
