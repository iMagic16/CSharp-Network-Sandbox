using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericServerBasedGameTest_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string TxtToSend = TxtCmdToSend.Text;
            TxtCmdToSend.Clear();

            //Program.
        }

        private void Server_Load(object sender, EventArgs e)
        {
            WriteToOutput("TCP network api test");
        }

        public void WriteToOutput(string InputText)
        {
            string AppendedText = DateTime.Now + InputText;
            TxtOutput.Text = AppendedText + Environment.NewLine;
        }
    }
}
