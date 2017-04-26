using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSummary.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseSummary.BL.Models;

namespace ExerciseSummary.BL.Repositories.Tests
{
    [TestClass()]
    public class PersonRepositoryTests
    {

        Database _db = null;
        public PersonRepositoryTests()
        {
            _db = new Database();
        }


        [TestMethod()]
        public void GetItemsTest()
        {
           
            PersonRepository pRep = new PersonRepository(_db);
            var result = pRep.GetItems();



            Assert.AreEqual(result.Count() ,4);
          
        }

        [TestMethod()]
        public void GetItemsByIdTest()
        {

            PersonRepository pRep = new PersonRepository(_db);
            var result = pRep.GetSingle(1);



            Assert.AreEqual(result.FirstName, "Arpad");

        }

        [TestMethod()]
        public void GetItemsByFunc()
        {

            PersonRepository pRep = new PersonRepository(_db);
            var result = pRep.GetItems().Where(x=>x.LastName=="Stoever");



            Assert.AreEqual(result.Count(), 2);

        }

     
    }
}