using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ExerciseSummary.Model.Models;

namespace ExerciseSummary.BL.Repositories.Tests
{
    [TestClass()]
    public class NewGenericRepositoryTests
    {


        Database _db = null;

        public NewGenericRepositoryTests()
        {
            _db = new Database();
        }


    

        [TestMethod()]
        public void NewGenericRepositoryGetItemsTest()
        {
            var rep = new NewGenericRepository<Person>();
            rep.AddRange(_db.Persons);

            var items = rep;

            Assert.AreEqual(items.Count(), 4);


        }


        [TestMethod()]
        public void GetItemsTest1()
        {
            var rep = new NewGenericRepository<Person>();
            rep.AddRange(_db.Persons);

            var items = rep.Where(n=>n.LastName=="Stoever") ;

            Assert.AreEqual(items.Count(), 2);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            var rep = new NewGenericRepository<Person>();
            rep.AddRange(_db.Persons);

            var item = rep.GetSingle(1);

            Assert.AreEqual(item.FirstName, "Arpad");
        }
    }
}