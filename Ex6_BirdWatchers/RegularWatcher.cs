using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_BirdWatchers
{
    class RegularWatcher: BirdWatcher
    {
        public RegularWatcher()
        { }
        public override void BirdWatcherAction(string Action)
        {
            string[] Reaction = { "{REG}OH, nice song", "{REG}I can enjoy the sing all day long", "{REG}It is so loud though!" };
            Console.WriteLine(Reaction[new Random().Next(0, Reaction.Length)]);
         
        }




    }
}