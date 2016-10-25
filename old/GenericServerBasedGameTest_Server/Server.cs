using System;
using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using System.Net;


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
            WriteToOutput("Server Client Loaded");


            //Trigger the method PrintIncomingMessage when a packet of type 'Message' is received
            //We expect the incoming object to be a string which we state explicitly by using <string>
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", PrintIncomingMessage);
            //Start listening for incoming connections
            // Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, 27015));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine(">Server listening for TCP connection on:");
            foreach (IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
                Console.WriteLine(">>{0}:{1}", localEndPoint.Address, localEndPoint.Port);

            //Let the user close the server
            Console.WriteLine(">Press any key to close server.");
            //       Console.ReadKey(true);

            //We have used NetworkComms so we should ensure that we correctly call shutdown
            //        NetworkComms.Shutdown();
        }

        public void WriteToOutput(string InputText)
        {
            string AppendedText = DateTime.Now + " | " + InputText;
            TxtOutput.Text = AppendedText + Environment.NewLine;
        }


        /// <summary>
        /// Writes the provided message to the console window
        /// </summary>
        /// <param name="header">The packet header associated with the incoming message</param>
        /// <param name="connection">The connection used by the incoming message</param>
        /// <param name="message">The message to be printed to the console</param>
        private static void PrintIncomingMessage(PacketHeader header, Connection connection, string message)
        {
            Console.WriteLine(">>>>(Server) A message was received from " + connection.ToString() + " which said '" + message + "'.");
            Console.WriteLine(connection.ConnectionInfo.NetworkIdentifier);
            //    connection.ConnectionInfo.NetworkIdentifier
            //    Console.WriteLine(connection.ConnectionInfo.RemoteEndPoint);

            string ClientIP = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Address);

            string ClientPORT = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Port);

            string MsgToSend = "ACK";
            string MsgType = "ID";

            SendMsg(ClientIP, Convert.ToInt32(ClientPORT), MsgType, MsgToSend);
        }


        static void SendMsg(string IP, int PORT, string MSGTYPE, string MSG)
        {
            try
            {
                Console.WriteLine(">Sending MSG '" + MSGTYPE + "%" + MSG + "'");
                NetworkComms.SendObject("Message", IP, PORT, MSGTYPE + "%" + MSG);
                Console.WriteLine(">Sent!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

        static void ShutdownConnection()
        {
            NetworkComms.Shutdown();
        }


    }
}
