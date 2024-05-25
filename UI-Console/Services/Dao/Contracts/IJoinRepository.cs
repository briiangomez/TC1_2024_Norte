using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dao.Contracts
{
    internal interface IJoinRepository<T>
    {
        void Insert(T obj);

        void Fill(T obj);
    }
}
