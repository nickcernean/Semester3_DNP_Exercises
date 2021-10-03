using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchoServer_Server
{
    public class RunClass
    {
        public static void Main(string[] args)
        {
            Client client = new Client("192.168.87.136", 1099);
            
            client.WriteDataToServer("Hello from client");

            string ReturnInput = client.ReturnDataFromServer();
            Console.WriteLine(ReturnInput);
            client.CloseConnection();
            Console.ReadLine();







        }
    }
}