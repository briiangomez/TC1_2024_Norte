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

	public sealed class PerfilRepository : IGenericDao<Perfil>
    {
		#region singleton
		private readonly static PerfilRepository _instance = new PerfilRepository();

		public static PerfilRepository Current
		{
			get
			{
				return _instance;
			}
		}

		private PerfilRepository()
		{
			//Implent here the initialization of your singleton
		}
        #endregion

        public void Add(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Perfil GetById(Guid id)
        {
            Perfil perfil = default;
            using (var dr = SqlHelper.ExecuteReader("FamiliaSelect", System.Data.CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdFamilia", id) }))
            {
                if (dr.Read())
                {
                    //Leo el registro del IdPatente
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    perfil = PerfilMapper.Current.Fill(values, 1);
                }
            }
            return perfil;
        }

        public List<Perfil> GetAll()
        {
            throw new NotImplementedException();
        }
        
    }

}
