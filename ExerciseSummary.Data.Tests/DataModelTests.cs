using ExerciseSummary.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseSummary.Data.EntityFramework.Tests
{
    [TestClass()]
    public class DataModelTests
    {
        [TestMethod()]
        public void SimpleDataAccessTest()
        {
            using (var db = new DataModel())
            {
                //r adr = new Adress {PostalCode="23879",City="Moelln" ,Street="WKW 109"};
                var adr = new Adress { PostalCode = "23879", City = "Moelln", Street = "Muehlenstarsse 35" };

                var per = new Person {  FirstName = "Georg", LastName = "Witt" };
                per.Adresses.Add(adr);

               // db.Adresses.Add(adr);
                db.Persons.Add(per);
                db.SaveChanges();


            }

            
        }
    }
}