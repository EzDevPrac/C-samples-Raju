using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
   public class PrefabricatedHouseBuilder: IHouseBuilder
    {
        private House house;
        public PrefabricatedHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            house.SetFoundation("Wood, laminate, and PVC flooring");
            Console.WriteLine("PrefabricatedHouseBuilder: Foundation complete...");
        }

        public void BuildStructure()
        {
            house.SetStructure("Structural steels and wooden wall panels");
            Console.WriteLine("PrefabricatedHouseBuilder: Structure complete...");
        }

        public void BuildRoof()
        {
            house.SetRoof("Roofing sheets");
            Console.WriteLine("PrefabricatedHouseBuilder: Roof complete...");
        }

        public void PaintHouse()
        {
            house.SetPainted(false);
            Console.WriteLine("PrefabricatedHouseBuilder: Painting not required...");
        }

        public void FurnishHouse()
        {
            house.SetFurnished(true);
            Console.WriteLine("PrefabricatedHouseBuilder: Furnishing complete...");
        }
        public House GetHouse()
        {
            Console.WriteLine("PrefabricatedHouseBuilder: Prefabricated house complete...");
            return this.house;
        }
    }
}
