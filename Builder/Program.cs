using Builder;
using System;

namespace DesignPattern.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {

            House FluentHouse = new HouseBuilder()
                .Floors(3)
                .Bedrooms(4)
                .HasKitchen()
                .HasLivingRoom()
                .Roof("Metal")
                .Build();
            Console.WriteLine("House Build with the follwing Requirement " + 
                "\nNumber of Floor: " + FluentHouse.Floor +
                 "\nNumber of BedRoom: " + FluentHouse.Bedrooms +
                 "\nHas Kitchen: " + FluentHouse.Kitchen +
                 "\nHasLivingRoom: " + FluentHouse.LivingRoom +
                 "\nRoofType: " + FluentHouse.Roof);
            Console.ReadLine();


        }
    }
}