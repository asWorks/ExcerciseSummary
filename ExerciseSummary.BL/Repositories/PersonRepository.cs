using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseSummary.BL.Interfaces;
using ExerciseSummary.BL.Models;
using System.Linq.Expressions;

namespace ExerciseSummary.BL.Repositories
{
    public class PersonRepository : IRepository<Models.Person>
    {

        Database _database = null;
        public PersonRepository(Database database)
        {
            if(database==null) throw new ArgumentNullException("Database","Database darf nicht null sein");
            _database = database;
        }
        public void Add(Person NewObject)
        {
            _database.Persons.Add(NewObject);
        }

        public IEnumerable<Person> GetItems()
        {
            return _database.Persons;
        }

        public IEnumerable<Person> GetItems(Func<Person, bool> predicate)
        {
            return _database.Persons.Where(predicate);
        }

        //public IQueryable<Person> GetItemsQA(Expression<Func<Person, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public Person GetSingle(int id)
        {
            return _database.Persons.Where(p => p.PersonId == id).SingleOrDefault();
        }
    }
}
