
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Models
{
    public class Person:EntityBase
    {

        public Person(int _ID):base(_ID)
        {
            Adresses = new List<Adress>();
        }

        public Person()
        {
            Adresses = new List<Adress>();
           
        }
      
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public List<Adress> Adresses { get; set; }

        

    }
}
