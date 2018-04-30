﻿using System;
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
                (context, new NetTcpBinding(), "net.tcp://localhost:9000/MyService");

            IContractService server = factory.CreateChannel();

            server.ServiceMethod();

            richTextBoxContent.Text = "connected";
        }
    }
}