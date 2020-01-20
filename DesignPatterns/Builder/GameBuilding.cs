using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class GameBuilding
    {
        public GameBuildingType BuildingType { get; set; }
        public int HitPoints { get; set; }
        public int AttackPoints { get; set; }
        public int Range { get; set; }
        public int PeopleInsideCapacity { get; set; }
    }
}