using System;
using System.ServiceModel;

namespace ContractLibrary
{
    [ServiceContract(CallbackContract = typeof(IContractClient))]
    public interface IContractService
    {
        [OperationContract(IsOneWay = true)]
        void ServiceMethod(string name);
    }
}
