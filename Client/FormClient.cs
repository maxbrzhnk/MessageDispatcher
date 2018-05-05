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
        InstanceContext context;
        DuplexChannelFactory<IContractService> factory;
        IContractService server;

        public FormClient()
        {
            InitializeComponent();
        }

        private void CreateChanel()
        {
            context = new InstanceContext(new Context(this));

            factory = new DuplexChannelFactory<IContractService>
                (context, new NetTcpBinding(), "net.tcp://localhost:50789/MyService");

            server = factory.CreateChannel();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CreateChanel();

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

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(textBoxName.Text == string.Empty))
                server.ExitClient(textBoxName.Text);
        }
    }
}
