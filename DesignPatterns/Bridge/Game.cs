using System;

namespace Bridge
{
    class Game
    {
        static void Main(string[] args)
        {
            //This application (game) has different types of creatures (human, serpent, dragon).
            //All of them can move and attack.
            //We take out these classes similar functions and put them into separate (implementation) clss
            var humanBehaviour = new HumanBehaviourLogic();
            var dragonBehaviourLogic = new DragonBehaviourLogic();
            var serpentBehaviourLogic = new SerpentBehaviourLogic();
            var human = new Peasant(humanBehaviour);
            var dragon = new Dragon(dragonBehaviourLogic);
            var snake = new Snake(serpentBehaviourLogic);
            human.Move();
            human.Attack();
            dragon.Move();
            dragon.Attack();
            snake.Move();
            snake.Attack();
            Console.ReadKey();
        }
    }
}