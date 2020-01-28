using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Peasant : Creature
    {
        public Peasant(BehaviourLogic behaviour) : base(behaviour)
        {

        }
        //we move the below logic to Behaviour logic subclasses so that 
        //1) We do not repeat code in the similar objects
        //2) We decouple the object from it's behaviour
        public void Attack()
        {
            base.behaviour.Attack();
        }
        public void Move()
        {
            base.behaviour.Move();
        }
    }
}
