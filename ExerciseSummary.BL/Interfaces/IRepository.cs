using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.BL.Interfaces
{

    public interface ICounter<T>
    {
        int Count { get; }
        T Get(int index);
    }



    public interface IRepository<T>
    {

        IEnumerable<T> GetItems();

        T GetSingle(int id);

        IEnumerable<T> GetItems(Func<T, bool> predicate);

        //IQueryable<T> GetItemsQA(Expression<Func<T, bool>> predicate);

        void Add(T NewObject);

    }


}
