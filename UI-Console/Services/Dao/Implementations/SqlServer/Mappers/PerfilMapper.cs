using Services.Dao.Contracts;
using Services.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dao.Implementations.SqlServer.Mappers
{

	public sealed class PerfilMapper : IObjectMapper<Perfil>
    {
		#region singleton
		private readonly static PerfilMapper _instance = new PerfilMapper();

		public static PerfilMapper Current
		{
			get
			{
				return _instance;
			}
		}

		private PerfilMapper()
		{
			//Implent here the initialization of your singleton
		}
        #endregion
        public Perfil Fill(object[] values, int profundidad)
        {
			if(profundidad == 0)
			{
                return new Perfil(null)
                {
                    Id = Guid.Parse(values[0].ToString()),
                    Name = values[1].ToString(),
                };
            }
            //Manejando los niveles de hidratación...
            Perfil perfil = new Perfil(null)
            {
                Id = Guid.Parse(values[0].ToString()),
                Name = values[1].ToString(),
            };
            FamiliaPatenteRepository.Current.Fill(perfil);
            return perfil;
        }
    }
}
