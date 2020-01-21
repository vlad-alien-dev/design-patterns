using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private GameBuildingBuilder builder;
        public void SetBuilder(GameBuildingBuilder bilder)
        {
            this.builder = bilder;
        }
        public void ConstructTower(GameBuildingBuilder builder)
        {
            builder.BuildingType(GameBuildingType.Tower);
            builder.AttackPoints(300);
            builder.Range(500);
        }
    }
}
