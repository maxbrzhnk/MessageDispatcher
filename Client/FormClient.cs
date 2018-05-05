using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ContractLibrary;

namespace Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            InstanceContext context = new InstanceContext(new Context(this));

            DuplexChannelFactory<IContractService> factory = new DuplexChannelFactory<IContractService>
                (context, new NetTcpBinding(), "net.tcp://localhost:50789/MyService");

            IContractService server = factory.CreateChannel();

            if(textBoxName.Text == string.Empty)
            {
                richTextBoxContent.Text = "Please input your name";

                return;
            }

            if(!server.ServiceMethod(textBoxName.Text))
            {
                richTextBoxContent.Text = "Please change your name";

                return;
            }

            this.buttonLogin.Enabled = false;
            this.textBoxName.ReadOnly = true;

            richTextBoxContent.Text = "Connected";
        }
    }
}
