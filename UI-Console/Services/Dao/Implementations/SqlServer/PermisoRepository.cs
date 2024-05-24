using Services.Dao.Contracts;
using Services.Dao.Helpers;
using Services.Dao.Implementations.SqlServer.Mappers;
using Services.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dao.Implementations.SqlServer
{

	public sealed class PermisoRepository : IGenericDao<Permiso>
    {
		#region singleton
		private readonly static PermisoRepository _instance = new PermisoRepository();

		public static PermisoRepository Current
		{
			get

			{
				return _instance;
			}
		}

		private PermisoRepository()
		{
			//Implent here the initialization of your singleton
		}
        #endregion

        public void Add(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Permiso GetById(Guid id)
        {
            Permiso permiso = default;
            using (var dr = SqlHelper.ExecuteReader("PatenteSelect", System.Data.CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdPatente", id) }))
            {
                if (dr.Read())
                {
                    //Leo el registro del IdPatente
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    permiso = PermisoMapper.Current.Fill(values,0);
                }
            }
            return permiso;
        }

        public List<Permiso> GetAll()
        {
            throw new NotImplementedException();
        }
       
    }

}
