using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_BirdWatchers
{
    class DeafBirdWatcher: BirdWatcher
    {
        public DeafBirdWatcher()
        { }

        public override void BirdWatcherAction(string Action)
        {   
            if(Action.Equals("Bird sings"))
            {
                Console.WriteLine("{DEAF}Can't hear");
            }
            Console.WriteLine("{DEAF}Did you see that!!");

        }


    }
}