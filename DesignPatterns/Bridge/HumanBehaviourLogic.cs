using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class HumanBehaviourLogic : BehaviourLogic
    {
        public void Attack()
        {
            Console.WriteLine("I hit");
        }

        public void Move()
        {
            Console.WriteLine("I walk");
        }
    }
}
