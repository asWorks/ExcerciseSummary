using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSummary.Model.Interfaces
{
    public interface IIdentity<T>
    {
       T ID { get; set; }
    }
}
