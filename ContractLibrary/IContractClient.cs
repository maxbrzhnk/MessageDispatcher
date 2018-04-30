using System;
using System.ServiceModel;

namespace ContractLibrary
{
    public interface IContractClient
    {
        [OperationContract(IsOneWay = true)]
        void ClientMethod(string message);
    }
}
