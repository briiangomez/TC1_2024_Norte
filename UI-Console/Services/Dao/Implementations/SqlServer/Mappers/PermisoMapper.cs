using Services.Dao.Contracts;
using Services.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dao.Implementations.SqlServer.Mappers
{
    public sealed class PermisoMapper : IObjectMapper<Permiso>
    {
        #region singleton
        private readonly static PermisoMapper _instance = new PermisoMapper();

        public static PermisoMapper Current
        {
            get
            {
                return _instance;
            }
        }

        private PermisoMapper()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Permiso Fill(object[] values, int prof)
        {
            return new Permiso()
            {
                Id = Guid.Parse(values[0].ToString()),
                Name = values[1].ToString(),
                DataKey = values[2].ToString()
            };
        }
    }
}
