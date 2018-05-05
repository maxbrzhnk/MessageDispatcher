using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ContractLibrary;

namespace MessageDispatcher
{
    public partial class FormService : Form
    {
        public static List<IContractClient> callbacks;

        public static List<string> names;

        private ServiceHost host;
        public FormService()
        {
            InitializeComponent();

            callbacks = new List<IContractClient>();

            names = new List<string>();

            host = new ServiceHost(typeof(Service));

            host.AddServiceEndpoint(typeof(IContractService), new NetTcpBinding(),
                "net.tcp://localhost:50789/MyService");

            host.Open();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Single process
            //foreach (IContractClient callback in callbacks)
            //{
            //    callback.ClientMethod(textBoxContent.Text);
            //    Thread.Sleep(100);
            //}

            //Parallel
            if (!(checkedListBoxClients.CheckedItems.Count == 0))
            {
                List<IContractClient> checkedCallbacks = new List<IContractClient>();

                foreach (IContractClient callback in callbacks)
                    checkedCallbacks.Add(callback);

                int namesCount = names.Count;

                int callbacksIterator = 0, namesIterator = 0;
                for (; namesIterator < namesCount; callbacksIterator++, namesIterator++)
                {
                    if (!checkedListBoxClients.CheckedItems.Contains(names[namesIterator]))
                    {
                        checkedCallbacks.RemoveAt(callbacksIterator);
       
                        callbacksIterator--;
                    }
                }

                Parallel.ForEach<IContractClient>(checkedCallbacks, (callback) => callback.ClientMethod(textBoxContent.Text));
                Thread.Sleep(100);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            foreach (string name in names)
            {
                if (!checkedListBoxClients.Items.Contains(name))
                    checkedListBoxClients.Items.Add(name);
            }

            checkedListBoxClients.Update();
        }
    }
}
