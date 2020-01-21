using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var army = new Army();
            army.AddCreature(new Knight(1, 5, 5, 10));
            army.AddCreature(new Goblin(3, 3, 33, 30));
            army.AddCreature(new Knight(7, 7, 77, 70));
            Console.WriteLine("My Army:");
            army.Report();
            Console.WriteLine("My doubled Army:");
            army.DoubleArmy();
            army.Report();
            Console.ReadKey();
        }
    }
}
