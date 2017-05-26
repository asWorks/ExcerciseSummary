using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Models
{
    public class Database
    {

 
        public Database()
        {
            Persons = new List<Person>
            {
                new Person(1){ FirstName="Arpad",LastName="Stoever"},
                new Person(2){FirstName="Michael",LastName="Stoever" },
                new Person(3){FirstName="Knut",LastName="Kummert" },
                new Person(4){FirstName="Georg",LastName="Witt"}

               // ,Adress=new Adress(1){City="Moelln",Street="Wasserkrüger Weg 109",PostalCode="23879"

            };

            var Adress = new Adress(1) { City = "Moelln", Street = "Wasserkrüger Weg 109", PostalCode = "23879" };

            foreach (var item in Persons)
            {
                item.Adresses.Add(Adress);
            }


        }

        public IList<Person> Persons { get; set; }
    }
}
