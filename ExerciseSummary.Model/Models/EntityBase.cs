
using ExerciseSummary.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Models
{
    public abstract class EntityBase:IIdentity<int>

    {
        public EntityBase(int _ID)
        {
            ID = _ID;
        }

        public EntityBase()
        {

        }
        public int ID { get; set ; }
    }
}
