using ExerciseSummary.Model.Interfaces;
using ExerciseSummary.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseSummary.BL.Repositories
{
    public class NewGenericRepository<T> :List<T>, IRepository<T> where T : EntityBase
    {
        public IList<T> Entities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IList<T> IRepository<T>.Entities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public IEnumerable<T> GetItems()
        //{
        //    return this.GetItems();
        //}

        //public IEnumerable<T> GetItems(Func<T, bool> predicate)
        //{
        //    return this.GetItems(predicate);
        //}

        public T GetSingle(int id)
        {
            return this.Where(n => n.ID == id).SingleOrDefault();
        }

        void IRepository<T>.Add(T NewObject)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetItems()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetItems(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetSingle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
