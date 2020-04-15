using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class ConstructionEngineer
    {
        private IHouseBuilder houseBuilder;
        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
        public House ConstructHouse()
        {
            this.houseBuilder.BuildFoundation();
            this.houseBuilder.BuildStructure();
            this.houseBuilder.BuildRoof();
            this.houseBuilder.PaintHouse();
            this.houseBuilder.FurnishHouse();
            return this.houseBuilder.GetHouse();
        }
    }
}
