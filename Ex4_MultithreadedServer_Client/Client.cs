using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace EchoServer_Server
{
    public class Client
    {
        TcpClient client;
        NetworkStream Stream;
        private bool running;
       
        public Client(string IP,int PORT)
        {
            Console.WriteLine("Starting client...");
            client = new TcpClient(IP, PORT);
            Stream = client.GetStream();
            this.running = false;
        }
        public void WriteDataToServer(string InputString)
        {
            byte[] DataToServer = Encoding.ASCII.GetBytes(InputString);
            Stream.Write(DataToServer, 0, DataToServer.Length);
        }
        public string ReturnDataFromServer()
        {
            byte[] DataFromServer = new byte[1024];
            int BytesRead = Stream.Read(DataFromServer, 0, DataFromServer.Length);
            string s = Encoding.ASCII.GetString(DataFromServer, 0, BytesRead);
            return s;
        }

        private void CloseConnection()
        {
            Console.WriteLine("Quiting connection...");
            Stream.Close();
            client.Close();
            running = false;
            Console.WriteLine("Disconnected");
        }

        public void RunClient()
        {
            running = true;
            while (running)
            { Console.WriteLine("Client>>");
                string ClientResponse = Console.ReadLine();
                if (ClientResponse.Equals("exit"))
                {
                    CloseConnection();
                }
                WriteDataToServer(ClientResponse);
                string ReturnInput = ReturnDataFromServer();
                Console.WriteLine("Server>>"+ReturnInput);
            }
        }
    }
}