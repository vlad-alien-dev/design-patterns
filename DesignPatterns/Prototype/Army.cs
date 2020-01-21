using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Army
    {
        private List<CreaturePrototype> creatures = new List<CreaturePrototype>();
        private List<CreaturePrototype> clonedCreatures = new List<CreaturePrototype>();

        public void AddCreature(CreaturePrototype creature)
        {
            this.creatures.Add(creature);
        }
        public void DoubleArmy()
        {
            foreach (var creature in this.creatures)
            {
                //here I clone creatures without initially knowing it's concrete type
                this.clonedCreatures.Add(creature.Clone());
            }
            this.creatures.AddRange(this.clonedCreatures);
        }
        public void Report()
        {
            foreach (var creature in this.creatures)
            {
                Console.WriteLine($"{creature.GetType().Name} - {creature.Level}");
            }
        }
    }
}
