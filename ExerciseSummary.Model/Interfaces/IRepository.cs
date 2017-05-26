using ExerciseSummary.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Interfaces
{

    public interface ICounter<T>
    {
        int Count { get; }
        T Get(int index);
    }



    public interface IRepository<TType>where TType :EntityBase
    {

        IList<TType> Entities { get; set; }

        IEnumerable<TType> GetItems();

        TType GetSingle(int id);

        IEnumerable<TType> GetItems(Func<TType, bool> predicate);

        
       void Add(TType NewObject);

    }


}
