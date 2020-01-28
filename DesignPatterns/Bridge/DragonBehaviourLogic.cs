using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class DragonBehaviourLogic : BehaviourLogic
    {
        public void Attack()
        {
            Console.WriteLine("I burn");
        }

        public void Move()
        {
            Console.WriteLine("I fly");
        }
    }
}
