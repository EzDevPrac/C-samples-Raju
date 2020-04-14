using System;

namespace builderImplementation
{
    class builderPattern
    {
        public static void Main(String[] args)
        {
            IHouseBuilder concreteHouseBuilder = new ConcreteHouseBuilder();
            ConstructionEngineer engineerA = new ConstructionEngineer(concreteHouseBuilder);
            House houseA = engineerA.constructHouse();
            Console.WriteLine("House is: " + houseA);
            PrefabricatedHouseBuilder prefabricatedHouseBuilder = new PrefabricatedHouseBuilder();
            ConstructionEngineer engineerB = new ConstructionEngineer(prefabricatedHouseBuilder);
            House houseB = engineerB.constructHouse();
            Console.WriteLine("House is: " + houseB);
        }
    }




    public class House
    {
        private string foundation;
        private string structure;
        private string roof;
        private bool furnished;
        private bool painted;
        public void setFoundation(string foundation)
        {
            this.foundation = foundation;
        }
        public void setStructure(string structure)
        {
            this.structure = structure;
        }
        public void setRoof(string roof)
        {
            this.roof = roof;
        }
        public void setFurnished(bool furnished)
        {
            this.furnished = furnished;
        }
        public void setPainted(bool painted)
        {
            this.painted = painted;
        }

        public string toString()
        {
            return "Foundation - " + foundation + " Structure - " + structure + " Roof - " + roof + " Is Furnished? " + furnished + " Is Painted? " + painted;
        }
    }



    public interface IHouseBuilder
    {
        void buildFoundation();
        void buildStructure();
        void buildRoof();
        void paintHouse();
        void furnishHouse();
        House getHouse();
    }



    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House house;
        public ConcreteHouseBuilder()
        {
            this.house = new House();
        }

        public void buildFoundation()
        {
            house.setFoundation("Concrete, brick, and stone");
            Console.WriteLine("ConcreteHouseBuilder: Foundation complete...");
        }

        public void buildStructure()
        {
            house.setStructure("Concrete, mortar, brick, and reinforced steel");
            Console.WriteLine("ConcreteHouseBuilder: Structure complete...");
        }

        public void buildRoof()
        {
            house.setRoof("Concrete and reinforced steel");
            Console.WriteLine("ConcreteHouseBuilder: Roof complete...");
        }

        public void paintHouse()
        {
            house.setPainted(true);
            Console.WriteLine("ConcreteHouseBuilder: Painting complete...");
        }

        public void furnishHouse()
        {
            house.setFurnished(true);
            Console.WriteLine("ConcreteHouseBuilder: Furnishing complete...");
        }
        public House getHouse()
        {
            Console.WriteLine("ConcreteHouseBuilder: Concrete house complete...");
            return this.house;
        }
    }






    public class PrefabricatedHouseBuilder : IHouseBuilder
    {
        private House house;
        public PrefabricatedHouseBuilder()
        {
            this.house = new House();
        }

        public void buildFoundation()
        {
            house.setFoundation("Wood, laminate, and PVC flooring");
            Console.WriteLine("PrefabricatedHouseBuilder: Foundation complete...");
        }

        public void buildStructure()
        {
            house.setStructure("Structural steels and wooden wall panels");
            Console.WriteLine("PrefabricatedHouseBuilder: Structure complete...");
        }

        public void buildRoof()
        {
            house.setRoof("Roofing sheets");
            Console.WriteLine("PrefabricatedHouseBuilder: Roof complete...");
        }

        public void paintHouse()
        {
            house.setPainted(false);
            Console.WriteLine("PrefabricatedHouseBuilder: Painting not required...");
        }

        public void furnishHouse()
        {
            house.setFurnished(true);
            Console.WriteLine("PrefabricatedHouseBuilder: Furnishing complete...");
        }
        public House getHouse()
        {
            Console.WriteLine("PrefabricatedHouseBuilder: Prefabricated house complete...");
            return this.house;
        }
    }



    public class ConstructionEngineer
    {
        private IHouseBuilder houseBuilder;
        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
        public House constructHouse()
        {
            this.houseBuilder.buildFoundation();
            this.houseBuilder.buildStructure();
            this.houseBuilder.buildRoof();
            this.houseBuilder.paintHouse();
            this.houseBuilder.furnishHouse();
            return this.houseBuilder.getHouse();
        }
    }

}
