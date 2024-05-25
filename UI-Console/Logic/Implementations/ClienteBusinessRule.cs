using Logic.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.BusinessExceptions;
using Services.Facade;
using Services.Domain.ServicesExceptions;

namespace Logic.Implementations
{
    //Armar singleton...
    public class ClienteBusinessRule : IGenericBusinessRule<Customer>
    {
        public void Add(Customer obj)
        {
            try
            {
                int a = 0;
                int b = 8;

                if (a < b)
                    throw new ClienteNoExisteException();
            }
            catch(ClienteNoExisteException ex)
            {
                ExceptionService.Current.HandleException(ex);
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
