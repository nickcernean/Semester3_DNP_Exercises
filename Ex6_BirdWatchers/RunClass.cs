using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_BirdWatchers
{
    class RunClass
    {

        public static void Main(string[] args)
        {
            Bird bird = new Bird();
            BirdWatcher BirdWatcher = new DeafBirdWatcher();
            BirdWatcher BirdWatcher2 = new DeafBirdWatcher();
            BirdWatcher BirdWatcher3 = new RegularWatcher();
            BirdWatcher BirdWatcher4 = new RegularWatcher();
            BirdWatcher BirdWatcher5 = new RegularWatcher();

            bird.BirdBehaviourChange += BirdWatcher.BirdWatcherAction;
            bird.BirdBehaviourChange += BirdWatcher5.BirdWatcherAction;
            bird.BirdBehaviourChange += BirdWatcher2.BirdWatcherAction;
            bird.BirdBehaviourChange += BirdWatcher3.BirdWatcherAction;
            bird.BirdBehaviourChange += BirdWatcher4.BirdWatcherAction;

            bird.BirdRandomBehaviour();
            Console.ReadLine();


        }
    }
}