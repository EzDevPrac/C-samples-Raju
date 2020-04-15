using Builder;
using System;

namespace DesignPatterns.Builder
{
    class BuilderPattern
    {
        public static void Main(String[] args)
        {
            IHouseBuilder concreteHouseBuilder = new ConcreteHouseBuilder();
            ConstructionEngineer engineerA = new ConstructionEngineer(concreteHouseBuilder);
            House houseA = engineerA.ConstructHouse();
            Console.WriteLine("House is: " + houseA);
            PrefabricatedHouseBuilder prefabricatedHouseBuilder = new PrefabricatedHouseBuilder();
            ConstructionEngineer engineerB = new ConstructionEngineer(prefabricatedHouseBuilder);
            House houseB = engineerB.ConstructHouse();
            Console.WriteLine("House is: " + houseB);
            Console.ReadLine();
        }
    }
}
