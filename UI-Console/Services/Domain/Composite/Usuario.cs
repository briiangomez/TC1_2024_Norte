using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Composite
{
    public class Usuario
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public List<Acceso> Accesos = new List<Acceso>();

        public Usuario()
        {
            
        }

        public List<Permiso> GetPermisos()
        {
            return new List<Permiso>();
        }

        public List<Perfil> GetPerfiles()
        {
            return new List<Perfil>();
        }

    }
}
