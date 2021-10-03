using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex4_DoctorsWaitingRoom
{
    class Patient
    {
        private int NumberInQueue;
        private WaitingRoom WaitingRoom;
        public Patient(WaitingRoom WaitingRoom)
        {
            this.WaitingRoom = WaitingRoom;
            WaitingRoom.NumberChange += ReactToNumber;
            this.NumberInQueue = WaitingRoom.DrawNumber();
            Console.WriteLine($"Patient {NumberInQueue} enters waiting room");
            Thread.Sleep(1000);
        }
        public void ReactToNumber(int TicketNumber)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Patient {NumberInQueue} looks up");
            Thread.Sleep(1000);
            if (NumberInQueue==TicketNumber)
            {
                Console.WriteLine("Patient" + NumberInQueue + " goes to the doctor's room");
            }
            else
            {
                Console.WriteLine("Patient" + NumberInQueue + " goes back looking at phone");
            }
        
        }
    }
}