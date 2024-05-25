using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IGenericBusinessRule <T>
    {
        void Add(T obj);

        void Update(T obj);
    }
}
