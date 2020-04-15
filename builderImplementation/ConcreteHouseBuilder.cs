using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class ConcreteHouseBuilder: IHouseBuilder
    {
        private House house;
        public ConcreteHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            house.SetFoundation("Concrete, brick, and stone");
            Console.WriteLine("ConcreteHouseBuilder: Foundation complete...");
        }

        public void BuildStructure()
        {
            house.SetStructure("Concrete, mortar, brick, and reinforced steel");
            Console.WriteLine("ConcreteHouseBuilder: Structure complete...");
        }

        public void BuildRoof()
        {
            house.SetRoof("Concrete and reinforced steel");
            Console.WriteLine("ConcreteHouseBuilder: Roof complete...");
        }

        public void PaintHouse()
        {
            house.SetPainted(true);
            Console.WriteLine("ConcreteHouseBuilder: Painting complete...");
        }

        public void FurnishHouse()
        {
            house.SetFurnished(true);
            Console.WriteLine("ConcreteHouseBuilder: Furnishing complete...");
        }
        public House GetHouse()
        {
            Console.WriteLine("ConcreteHouseBuilder: Concrete house complete...");
            return this.house;
        }

    }
}
