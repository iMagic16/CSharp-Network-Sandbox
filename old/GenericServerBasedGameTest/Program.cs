using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;

namespace GenericServerBasedGameTest_Client
{
    static class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Client());
            
        }

    }
}
