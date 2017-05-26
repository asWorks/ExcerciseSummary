using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSummary.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseSummary.Model.Models;

namespace ExerciseSummary.Data.EntityFramework.Tests
{
    [TestClass()]
    public class EF_GenericRepositoryTests
    {
        [TestMethod()]
        public void EF_GenericRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetItemsTest()
        {
            var db = new DataModel();
            var efRep = new EF_GenericRepository<Person>(db);
            var res = efRep.GetItems();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod()]
        public void GetItemsTest1()
        {
            var db = new DataModel();
            var efRep = new EF_GenericRepository<Person>(db);
            var res = efRep.GetItems().Where(n => n.LastName == "Stoever"); 
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            Assert.Fail();
        }
    }
}