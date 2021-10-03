using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace EchoServer
{
    public class Server 
    {   TcpListener Listener;
        TcpClient Client;
        private bool running;
        public Server(string IP,int PORT)
        {   
            Console.WriteLine("Starting server...");
            IPAddress ParsedIP = IPAddress.Parse(IP);
            Listener = new TcpListener(ParsedIP, PORT); 
            Listener.Start();
           
            Console.WriteLine("Server started...");
            this.running = false;
        } 
        public NetworkStream ClientConnection()
        {   Console.WriteLine("Waiting for client...");
            Client = Listener.AcceptTcpClient();
            
            Console.WriteLine("Client connected...");
            NetworkStream stream = Client.GetStream();
            
            return stream;
        }

        
        public void RunServer()
        {
            while (true)
            {
                NetworkStream ClientStream = ClientConnection();
                ClientHandler ClientHandler = new ClientHandler(ClientStream, Client);
                Thread newThread = new Thread(() =>ClientHandler.RunClientServerCommunication() );
                newThread.Start();
                
                running = true;
            }
        }
        
    }
}