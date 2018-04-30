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
        public void ServiceMethod()
        {
            FormService.callbacks.Add(OperationContext.Current.GetCallbackChannel<IContractClient>());
        }
    }
}
