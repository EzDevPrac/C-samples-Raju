using System;
using Xunit;

namespace Builder.Test
{
    public class HouseBuilding
    {
        House FluentHouse = new HouseBuilder().Floors(3)
                .Bedrooms(4)
                .HasKitchen()
                .HasLivingRoom()
                .Roof("Metal")
                .Build();
        [Fact]
        public void Floor()
        {

            var Floor = FluentHouse.Floors;
            Assert.Equal(3, Floor);
         }
        [Fact]
        public void Bedroom()
        {
            var Bedroom = FluentHouse.Bedrooms;
            Assert.Equal(4, Bedroom);
        }



        [Fact]
        public void HasKitchen()
        {
            var Haskitchen = FluentHouse.Kitchen;
            Assert.True(Haskitchen);
        }


        [Fact]
        public void HasLivingRoom()
        {
            var HasLivingRoom = FluentHouse.LivingRoom;
            Assert.True(HasLivingRoom);
        }

        [Fact]
        public void Roof()
        {

            var Roof = FluentHouse.Roof;
            Assert.Equal("Metal", Roof);
        }

    }
}
