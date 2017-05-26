using ExerciseSummary.Model.Interfaces;
using ExerciseSummary.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Data.EntityFramework
{
    public class EF_GenericRepository<T> : IRepository<T> where T : EntityBase
    {

       private DataModel dbContext { get; set; }
        internal DbSet<T> dbSet;


        public EF_GenericRepository(DataModel _Context)
        {
            dbContext = new DataModel();
            this.dbSet = dbContext.Set<T>();

        }

        public IList<T> Entities { get; set ; }

        public void Add(T NewObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItems()
        {
            IEnumerable<T> query = dbSet;
            var res = query.ToList();
            var sql = ((System.Data.Entity.Core.Objects.ObjectQuery)query)
            .ToTraceString();
            return query.ToList();
        }

        public IEnumerable<T> GetItems(Func<T, bool> predicate)
        {
            IQueryable<T> query = dbSet;
            var res = query.ToList();
            var sql = ((System.Data.Entity.Core.Objects.ObjectQuery)query)
            .ToTraceString();
            return query.Where(predicate).ToList();

            
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
