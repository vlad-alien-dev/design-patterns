using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// The 'Prototype' abstract class

    public abstract class CreaturePrototype
    {
        private int level;
        private int attack;
        private int deffence;
        private int magicPower;
        public CreaturePrototype(int level, int attack, int deffence, int magicPower)
        {
            this.level = level;
            this.attack = attack;
            this.deffence = deffence;
            this.magicPower = magicPower;
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Deffence
        {
            get { return deffence; }
            set { deffence = value; }
        }
        public int MagicPower
        {
            get { return magicPower; }
            set { magicPower = value; }
        }
        public abstract CreaturePrototype Clone();
    }
}
