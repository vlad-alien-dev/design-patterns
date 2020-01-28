using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Creature //abstraction
    {
        protected BehaviourLogic behaviour;
        public Creature(BehaviourLogic behaviour)
        {
            this.behaviour = behaviour;
        }
    }
}
