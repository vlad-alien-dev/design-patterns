using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SerpentBehaviourLogic : BehaviourLogic
    {
        public void Attack()
        {
            Console.WriteLine("I bite");
        }

        public void Move()
        {
            Console.WriteLine("I slither");
        }
    }
}
