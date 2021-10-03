using System;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace EchoServer
{
    public class ClientHandler
    {
        private bool running;
        private NetworkStream Stream;
        private TcpClient Client;
     public ClientHandler(NetworkStream Stream,TcpClient Client)
     {
         this.Stream = Stream;
         this.Client = Client;
         this.running = false;
     }
     public string ReadDataFromClient()
     {
         byte[] DataFromClient = new byte[1024];
         int BytesRead =Stream.Read(DataFromClient, 0, DataFromClient.Length);
         string s = Encoding.ASCII.GetString(DataFromClient, 0, BytesRead);
         return s;
     }
     
     public void SendDataToClient(string response)
     {
         byte[] DataToClient = Encoding.ASCII.GetBytes($"Returning {response}");
         Stream.Write(DataToClient, 0, DataToClient.Length);
     }

     public void ClientServerCommunication()
     {
         running = true;
         while (running)
         {
             String ClientResponse = ReadDataFromClient();
             if (ClientResponse.Equals("exit"))
             {
                 running = false;
                 Client.Close();
             }
             Console.WriteLine("Client>>"+ ClientResponse);
             Console.WriteLine("Server>>");
             String ServerResponse = Console.ReadLine();
             SendDataToClient(ServerResponse);
         }
     }
     
     

     public void RunClientServerCommunication()
     {
         Thread newThread = new Thread( ()=>ClientServerCommunication());
         newThread.Start();
     }
     
    
    
    }
    
}