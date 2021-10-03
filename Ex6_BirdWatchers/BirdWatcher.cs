using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_BirdWatchers
{
    public abstract class BirdWatcher
    {
        Bird bird;
        public BirdWatcher()
        {
            bird = new Bird();
        }
        
        public abstract void BirdWatcherAction(string Action);
        


        

    }
}