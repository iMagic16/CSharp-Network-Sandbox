using System;
using System.Net;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using System.Windows.Forms;

namespace GenericServerBasedGameTest_Server
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Server());
        }

    }

}
