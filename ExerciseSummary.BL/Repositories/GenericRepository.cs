using ExerciseSummary.Model.Interfaces;
using ExerciseSummary.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExerciseSummary.BL.Repositories
{
    public class GenericRepository<T>:IRepository<T> where T:EntityBase
    {
       
        private static readonly log4net.ILog log = ExerciseSummary.Common.LogHelper.GetLogger();

            

        public GenericRepository(IList<T> _Entities)
        {
            if (_Entities == null) throw new ArgumentNullException("Entities", "Entities darf nicht null sein");
            
            Entities = _Entities;
        }

       

        public  IList<T>Entities { get ; set ; }

     
        public void Add(T NewObject)
        {
           
            Entities.Add(NewObject);

            log.Error("Here comes the log");

        }

        public IEnumerable<T> GetItems()
        {
            return (Entities);
        }

        public IEnumerable<T> GetItems(Func<T, bool> predicate)
        {
            return Entities.Where(predicate);
        }


        public T GetSingle(int ID)
        {
            return Entities.Where(n => n.ID == ID).SingleOrDefault();
        }

      
    }
}
