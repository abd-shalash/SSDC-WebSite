using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
   public interface IPersonRepository
    {
        IEnumerable<Person> People { get; }
        
        //this changes made by nasser
        
        //this is a new change
<<<<<<< Updated upstream
        
        ///jkhkjh
=======
        // this change was make on mac
>>>>>>> Stashed changes
    }
}
