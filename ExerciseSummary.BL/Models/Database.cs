using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.BL.Models
{
    public class Database
    {

 
        public Database()
        {
            Persons = new List<Person>
            {
                new Person{PersonId=1,FirstName="Arpad",LastName="Stoever"},
                new Person{PersonId=2,FirstName="Michael",LastName="Stoever"},
                new Person{PersonId=3,FirstName="Knut",LastName="Kummert"},
                new Person{PersonId=4,FirstName="Georg",LastName="Witt"}

            };
        }

       public List<Person> Persons { get; set; }
    }
}
