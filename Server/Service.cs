using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ContractLibrary;


namespace MessageDispatcher
{
    class Service : IContractService
    {
        public bool ServiceMethod(string name)
        {
            if (FormService.names.Contains(name))
                return false;

             FormService.names.Add(name);

             FormService.callbacks.Add(OperationContext.Current.GetCallbackChannel<IContractClient>());

            return true;
        }

        public void ExitClient(string name)
        {
            FormService.names.Remove(name);

            FormService.callbacks.Remove(OperationContext.Current.GetCallbackChannel<IContractClient>());            
        }
    }
}
