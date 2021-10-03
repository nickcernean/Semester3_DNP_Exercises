using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_DoctorsWaitingRoom
{
    class RunClass
    {
        public static void Main(string[] args)
        {
            WaitingRoom WaitingRoom = new WaitingRoom();

            var John = new Patient(WaitingRoom);
            var Andrew = new Patient(WaitingRoom);
            var Rick = new Patient(WaitingRoom);



            WaitingRoom.RunWaitingRoom();
            Console.ReadLine();

        }
    }
}