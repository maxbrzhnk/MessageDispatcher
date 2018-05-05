using System;
using System.ServiceModel;

namespace ContractLibrary
{
    [ServiceContract(CallbackContract = typeof(IContractClient))]
    public interface IContractService
    {
        [OperationContract(IsOneWay = false)]
        bool ServiceMethod(string name);

        [OperationContract(IsOneWay = true)]
        void ExitClient(string name);
    }
}
