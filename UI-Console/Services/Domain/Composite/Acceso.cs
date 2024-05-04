using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Composite
{
    public abstract class Acceso
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public abstract void Add(Acceso component);

        public abstract void Remove(Acceso component);

        public abstract int GetCount();
    }
}
