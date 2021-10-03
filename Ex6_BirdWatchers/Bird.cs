using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_BirdWatchers
{
    class Bird
    {
        public Action<string> BirdBehaviourChange;
        public Bird()
        { }
        public string BirdRandomBehaviour()
        {
            string[] BirdBehaviour = { "Bird flaps wings", "Bird sings" ,"Bird does mating dance"};
            while (true)
            {
                var RandomNumber = new Random().Next(0, BirdBehaviour.Length);
                Console.WriteLine(BirdBehaviour[RandomNumber]);
                BirdBehaviourChange.Invoke(BirdBehaviour[RandomNumber]);
            }
        }
    }
}