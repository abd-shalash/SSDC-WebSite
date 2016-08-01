using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.Concrate
{
    public class EF_PersonRepository : IPersonRepository
    {
        private readonly EF_DBContext context = new EF_DBContext();

        public IEnumerable<Person> People
        {
            get { return context.People; }
        }


        public bool SaveUser(Person user)
        {
            if (user.ID == 0)
            {
               
      
           var temp= context.People.FirstOrDefault(u => u.Username==user.Username);
                Person dbEntry = user;
                if ((temp == null))
                {
                    dbEntry.ID = user.ID;

                    dbEntry.Fname = user.Fname;
                    dbEntry.Mname = user.Mname;
                    dbEntry.Lname = user.Lname;
                    dbEntry.Password = user.Password;
                    context.People.Add(dbEntry);
                    context.SaveChanges();
                }
                else { return false; }
            }

            return true;
        }

    }
}
