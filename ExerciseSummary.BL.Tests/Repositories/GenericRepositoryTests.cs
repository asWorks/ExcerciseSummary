using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using ExerciseSummary.Model.Models;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace ExerciseSummary.BL.Repositories.Tests
{
    [TestClass()]
    public class GenericRepositoryTests
    {

        private static readonly log4net.ILog log = ExerciseSummary.Common.LogHelper.GetLogger();


        Database _db = null;

        public GenericRepositoryTests()
        {
            _db = new Database();
        }



        [TestMethod()]
        public void TestDeserialization()
        {
            var serializer = new JavaScriptSerializer();


            var rep = new GenericRepository<Person>(_db.Persons);

            var res = rep.GetItems();

            var ser = serializer.Serialize(res);

            string json = JsonConvert.SerializeObject(res);

            var deSer = JsonConvert.DeserializeObject(json);

            var deserializedResult = serializer.Deserialize<List<Person>>(ser);


            File.WriteAllText(@"c:\Data\movie.json", JsonConvert.SerializeObject(res));

            File.WriteAllText(@"c:\Data\movieX.json", json);

            var reReadText = File.ReadAllText(@"c:\Data\movieX.json");

            var deSerObject = serializer.Deserialize<List<Person>>(reReadText);

            using (StreamWriter file = File.CreateText(@"c:\Data\movie12.json"))
            {

                var sb = new StringBuilder(json);
                JsonSerializer serial = new JsonSerializer();
                serial.Serialize(file, res);


            }


            using (StreamReader file = File.OpenText(@"c:\Data\movie12.json"))
            {

               
                JsonSerializer serial = new JsonSerializer();
               var xx= (List<Person>)serial.Deserialize(file,typeof(List<Person>));


            }


            Assert.AreEqual(res.Count(), 4);

        }



        [TestMethod()]
        public void GenericRepositoryTest()
        {
            var rep = new GenericRepository<Person>(_db.Persons);

            var res = rep.GetItems();
            Assert.AreEqual(res.Count(), 4);

        }

        [TestMethod()]
        public void AddTest()
        {

            log.Error("Test");
            var rep = new GenericRepository<Person>(_db.Persons);

            var p = new Person(5) { FirstName = "Claudia", LastName = "Stoever" };
            rep.Add(p);
            var res = rep.GetItems();
            Assert.AreEqual(res.Count(), 5);




        }

        [TestMethod()]
        public void GetItemsTest()
        {
            var rep = new GenericRepository<Person>(_db.Persons);

            var res = rep.GetItems();
            Assert.AreEqual(res.Count(), 4);
        }

        [TestMethod()]
        public void GetItemsTest1()
        {
            var rep = new GenericRepository<Person>(_db.Persons);

            var res = rep.GetItems().Where(n => n.LastName == "Stoever");
            Assert.AreEqual(res.Count(), 2);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            var rep = new GenericRepository<Person>(_db.Persons);
            var res = rep.GetItems().Where(n => n.ID == 1).SingleOrDefault();
            Assert.AreEqual(res.FirstName, "Arpad");
        }


        [TestMethod()]
        public void GetSingleTest1()
        {
            var rep = new GenericRepository<Person>(_db.Persons);
            var res = rep.GetSingle(1);
            Assert.AreEqual(res.FirstName, "Arpad");
        }
    }
}