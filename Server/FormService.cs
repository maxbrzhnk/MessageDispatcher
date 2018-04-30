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
    

        private ServiceHost host;
        public FormService()
        {
            InitializeComponent();

            callbacks = new List<IContractClient>();

            // Create host for service.
            host = new ServiceHost(typeof(Service));

            // Add end point.
            host.AddServiceEndpoint(typeof(IContractService), new NetTcpBinding(),
                "net.tcp://localhost:9000/MyService");

            // Запуск хоста.
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
            Parallel.ForEach<IContractClient>(callbacks, (callback) => callback.ClientMethod(textBoxContent.Text));
            Thread.Sleep(100);
        }
    }
}
