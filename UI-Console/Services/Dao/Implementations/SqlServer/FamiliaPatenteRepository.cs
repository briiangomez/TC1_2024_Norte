using Services.Dao.Contracts;
using Services.Dao.Helpers;
using Services.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Services.Dao.Implementations.SqlServer
{

	public sealed class FamiliaPatenteRepository : IJoinRepository<Perfil>
    {
		#region singleton
		private readonly static FamiliaPatenteRepository _instance = new FamiliaPatenteRepository();

		public static FamiliaPatenteRepository Current
		{
			get
			{
				return _instance;
			}
		}

		private FamiliaPatenteRepository()
		{
			//Implent here the initialization of your singleton
		}
		#endregion

		private string selectStatement = "Familia_PatenteSelectByIdFamilia";
        public void Fill(Perfil obj)
        {
			using (var dr = SqlHelper.ExecuteReader(selectStatement, System.Data.CommandType.StoredProcedure,
				new SqlParameter[]{new SqlParameter("@IdFamilia", obj.Id) }))
			{
				while(dr.Read()) {
					//Leo el registro del IdPatente
					object[] values = new object[dr.FieldCount];
					dr.GetValues(values);
					Guid idPermiso = Guid.Parse(values[1].ToString());
					obj.Accesos.Add(PermisoRepository.Current.GetById(idPermiso));
				}
			}
        }        
    }

}
