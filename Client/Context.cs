using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ContractLibrary;

namespace Client
{
    class Context : IContractClient
    {
        private FormClient window;

        public Context(FormClient window)
        {
            this.window = window;
        }

        public void ClientMethod(string message)
        {
            window.richTextBoxContent.Text = message;
        }
    }
}
