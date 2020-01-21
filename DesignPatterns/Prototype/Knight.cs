using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// The 'ConcretePrototype' class

    public class Knight : CreaturePrototype
    {
        public Knight(int level, int attack, int deffence, int magicPower)
            : base(level, attack, deffence, magicPower)
        {

        }
        public Knight(Knight knight) : base(knight.Level,
           knight.Attack, knight.Deffence, knight.MagicPower)
        { 
        }

        public override CreaturePrototype Clone()
        {
            return new Knight(this);
        }
    }
}
