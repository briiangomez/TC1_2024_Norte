using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Composite
{
    public class Permiso : Acceso
    {
        public TipoPermiso tipoPermiso;

        public string DataKey { get; set; }

        public Permiso(TipoPermiso tipo = TipoPermiso.UI)
        {
            tipoPermiso = tipo;
        }

        public override void Add(Acceso component)
        {
            throw new Exception("No se puede agregar un elemento...");
        }

        public override int GetCount()
        {
            return 0;
        }

        public override void Remove(Acceso component)
        {
            throw new Exception("No se puede eliminar un elemento...");

        }
    }
}

public enum TipoPermiso
{
    UI,
    Control,
    UseCase,
    BusinessRule,
    DataAccess
}
