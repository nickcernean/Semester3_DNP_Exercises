using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace EchoServer
{
    public class RunClass
    {
        
        public static void Main(string[] args)
        {
            Server server = new Server("192.168.87.136", 1099);
            while(true)
            {
                NetworkStream Stream=server.ClientConnection();
                string s= server.ReadDataFromClient(Stream);
                Console.WriteLine(s);
                server.SendDataToClient("hello there", Stream);
                server.CloseConnection();
                Console.ReadLine();

            }



        }
    }
}