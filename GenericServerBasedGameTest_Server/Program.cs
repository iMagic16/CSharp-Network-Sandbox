using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
namespace GenericServerBasedGameTest_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trigger the method PrintIncomingMessage when a packet of type 'Message' is received
            //We expect the incoming object to be a string which we state explicitly by using <string>
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", PrintIncomingMessage);
            //Start listening for incoming connections
            Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, 7700));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine(">Server listening for TCP connection on:");
            foreach (IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
                Console.WriteLine(">>{0}:{1}", localEndPoint.Address, localEndPoint.Port);

            //Let the user close the server
            Console.WriteLine(">Press any key to close server.");
            Console.ReadKey(true);

            //We have used NetworkComms so we should ensure that we correctly call shutdown
            NetworkComms.Shutdown();
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

        //    Console.WriteLine(connection.ConnectionInfo.RemoteEndPoint);

            string ClientIP = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Address);

            string ClientPORT = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Port);

            string MsgToSend = "ACK";

            SendMsg(ClientIP, Convert.ToInt32(ClientPORT), MsgToSend);
        }


        static void SendMsg(string IP, int PORT, string MSG)
        {
            try
            {
                Console.WriteLine(">Sending MSG '" + MSG + "'");
                NetworkComms.SendObject("Message", IP, PORT, MSG);
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
