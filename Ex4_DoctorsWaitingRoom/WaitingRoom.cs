using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex4_DoctorsWaitingRoom
{
    class WaitingRoom
    {
        public Action<int> NumberChange ;
        private int CurrentNumber;
        private int TicketCount;

        public WaitingRoom()
        {
            this.TicketCount = 0;
            this.CurrentNumber = 0;
        }
        public void RunWaitingRoom()
        {
            while (CurrentNumber < TicketCount)
            {
                CurrentNumber++;
                Console.WriteLine("Patient number { " + CurrentNumber + "} can now enter");
                NumberChange(CurrentNumber);
                Thread.Sleep(1000);
            }
        } 
        public int DrawNumber()
        {
            TicketCount++;
            return TicketCount;
        }
    }
}