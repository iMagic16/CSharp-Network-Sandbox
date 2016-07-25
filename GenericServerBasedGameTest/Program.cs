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
        static string serverInfo, serverIP, MsgToSend, MsgType = "";
        static int serverPort;

        static void Main()
        {

            Console.WriteLine(">Starting Client");
            serverInfo = "127.0.0.1:7700"; //server IP:Port
            Console.WriteLine(">>serverInfo = {0}", serverInfo);
            Console.WriteLine(">>Splitting into seperate vars");
            GetServerIPAndPort(serverInfo);
            SetupListener();

            MsgToSend = "ConnectMe";
            MsgType = "Connect";
            SendMsg(serverIP, serverPort, MsgType, MsgToSend);

            // ShutdownConnection();

            Console.ReadLine();
            ShutdownConnection();
        }


        static void ParseReceivedMsg(string MessageType, string Message)
        {
            Console.WriteLine("PARSING: " + MessageType + ": " + Message);


            switch (MessageType)
            {
                case "LoginReq":
                    Console.WriteLine(MessageType + " Received. (" + Message + ")");
                    break;

                case "CharReq":
                    Console.WriteLine(MessageType + " Received. (" + Message + ")");
                    break;

                case "Message": //default
                    Console.WriteLine(MessageType + " Received. (" + Message + ")");
                    break;

                default:
                    Console.WriteLine("Message Type Unknown");
                    break;
            }




            //       Console.ReadLine();


        }



        static void SendMsg(string IP, int PORT, string MSGTYPE, string MSG)
        {
            try
            {
                Console.WriteLine(">Sending MSG '" + MSG + "'");
                NetworkComms.SendObject("Message", IP, PORT, MSGTYPE + ":" + MSG);
                Console.WriteLine(">Sent!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;

            }

        }

        static void ShutdownConnection()
        {
            NetworkComms.Shutdown();
        }

        static void GetServerIPAndPort(string serverInformation)
        {
            serverIP = serverInformation.Split(':').First();
            Console.WriteLine(">>>IP: {0}", serverIP);
            serverPort = Convert.ToInt32(serverInformation.Split(':').Last());
            Console.WriteLine(">>>Port: {0}", serverPort);

        }



        static void SetupListener()
        {

            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", PrintIncomingMessage);
            Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, 7701));

        }


        private static void PrintIncomingMessage(PacketHeader header, Connection connection, string message)
        {
            Console.WriteLine(">>>>(Client) A message was received from " + connection.ToString() + " which said '" + message + "'.");
            ParseReceivedMsg(header.PacketType, message.ToString());

            //   string ClientIP = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Address);
            //  string ClientPORT = Convert.ToString(((System.Net.IPEndPoint)connection.ConnectionInfo.RemoteEndPoint).Port);

            //  MsgToSend = message + "ACK'd";

            // SendMsg(ClientIP, Convert.ToInt32(ClientPORT), MsgToSend);
        }


    }
}
