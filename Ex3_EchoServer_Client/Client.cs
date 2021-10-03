using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;
namespace EchoServer_Server
{
    public class Client
    {
        TcpClient client;
        NetworkStream Stream;
       
        public Client(string IP,int PORT)
        {
            Console.WriteLine("Starting client...");
            client = new TcpClient(IP, PORT);
            Stream = client.GetStream();
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

        public void CloseConnection()
        {
            Stream.Close();
            client.Close();
        }



    }
}