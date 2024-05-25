using Services.Domain.ServicesExceptions;
using Services.Facade.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.BusinessExceptions
{
    public class ClienteNoExisteException : BLLException
    {
        public ClienteNoExisteException(): base("El cliente no existe".Translate() , true)
        {
            
        }
    }
}
