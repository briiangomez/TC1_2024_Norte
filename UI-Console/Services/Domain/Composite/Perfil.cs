using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Composite
{
    public class Perfil : Acceso
    {
        private List<Acceso> accesos = new List<Acceso>();

        public string Description { get; set; }


        public Perfil(Acceso acceso)
        {
            accesos.Add(acceso);
        }

        public override void Add(Acceso component)
        {
            if (component != null)
            {
                accesos.Add(component);
            }
        }

        public override int GetCount()
        {
            return accesos.Count;
        }

        public override void Remove(Acceso component)
        {
            //Validacion no quedarme sin hijos

            //LinQ -> Expresiones Lambda
            accesos.RemoveAll(o => o.Id == component.Id);
        }

        public List<Acceso> Accesos
        {
            get
            {
                return accesos;
            }
        }
    }
}
