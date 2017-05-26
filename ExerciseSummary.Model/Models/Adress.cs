using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Models
{
    public class Adress:EntityBase
    {

        public Adress(int _ID):base(_ID)
        {

        }

        public Adress()
        {

        }


        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public int PersonID { get; set; }

        public Person Person { get; set; }
    }
}
