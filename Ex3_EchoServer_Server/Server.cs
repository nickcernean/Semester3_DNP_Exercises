using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace EchoServer
{
    public class Server
    {   TcpListener Listener;
        TcpClient Client;
        public Server(string IP,int PORT)
        {
            Console.WriteLine("Starting server...");
            IPAddress ParsedIP = IPAddress.Parse(IP);
            Listener = new TcpListener(ParsedIP, PORT);
            Listener.Start();
            Console.WriteLine("Server started...");

        } 
        public NetworkStream ClientConnection()
        {
            Client = Listener.AcceptTcpClient();
            Console.WriteLine("Client connected...");
            NetworkStream stream = Client.GetStream();
            return stream;
        }
        public string ReadDataFromClient(NetworkStream Stream)
        {
            byte[] DataFromClient = new byte[1024];
            int BytesRead =Stream.Read(DataFromClient, 0, DataFromClient.Length);
            string s = Encoding.ASCII.GetString(DataFromClient, 0, BytesRead);
            return s;
        }
        public void SendDataToClient(string response,NetworkStream Stream)
        {
            byte[] DataToClient = Encoding.ASCII.GetBytes($"Returning {response}");
            Stream.Write(DataToClient, 0, DataToClient.Length);
        }

        public void CloseConnection()
        {
            Client.Close();
        }

    }
}