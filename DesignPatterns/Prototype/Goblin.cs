using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// The 'ConcretePrototype' class

    public class Goblin : CreaturePrototype
    {
        public Goblin(int level, int attack, int deffence, int magicPower)
            : base(level, attack, deffence, magicPower)
        {

        }
        public Goblin(Goblin goblin) : base(goblin.Level,
           goblin.Attack, goblin.Deffence, goblin.MagicPower)
        {
        }

        public override CreaturePrototype Clone()
        {
            return new Goblin(this);
        }
    }
}
