using ExerciseSummary.BL.Interfaces;
using ExerciseSummary.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.BL.Repositories
{
    public class GenericRepository<T> : IRepository<T>
    {

        //  http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle
        //  http://www.tugberkugurlu.com/archive/clean-better-and-sexier-generic-repository-implementation-for-entity-framework

        Database _database = null;
        public GenericRepository(Database database)
        {
            if (database == null) throw new ArgumentNullException("Database", "Database darf nicht null sein");
            _database = database;
        }
        public void Add(T NewObject)
        {
           
        }

        public IEnumerable<T> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItems(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
