using ExerciseSummary.Model.Interfaces;
using ExerciseSummary.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.BL.Repositories
{
    class EFRepository<T> : IRepository<T> where T : EntityBase
    {
        public IList<T> Entities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(T NewObject)
        {
            throw new NotImplementedException();
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
