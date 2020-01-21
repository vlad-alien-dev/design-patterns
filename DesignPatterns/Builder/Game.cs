using System;

namespace Builder
{
    class Game
    {
        static void Main(string[] args)
        {
            var castle = new GameBuildingBuilder()
                .BuildingType(GameBuildingType.Castle)
                .HitPoints(500)
                .AttackPoints(50)
                .Range(50)
                .PeopleInsideCapacity(50);
            var worldWonder = new GameBuildingBuilder()
                .BuildingType(GameBuildingType.WorldWonder)
                .HitPoints(1000);

            var house = new GameBuildingBuilder()
                .HitPoints(100)
                .PeopleInsideCapacity(5);

            Console.WriteLine(castle.Build());
            Console.WriteLine(worldWonder.Build());
            Console.WriteLine(house.Build());
            var tBuilder = new GameBuildingBuilder();
            

            var director = new Director();
            director.ConstructTower(tBuilder);
            Console.WriteLine(tBuilder.Build());

            Console.ReadKey();
        }
    }
}