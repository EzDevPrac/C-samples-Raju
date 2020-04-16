using System;
using Xunit;

namespace Builder.Test
{
    public class HouseBuilding
    {
        [Fact]
        public void HouseTest()
        {
            House FluentHouse = new HouseBuilder().Floors(3)
                .Bedrooms(4)
                .HasKitchen()
                .HasLivingRoom()
                .Roof("Metal")
                .Build();
            var Roof = FluentHouse.Roof;
            Assert.Equal("Metal", Roof);


            var Haskitchen = FluentHouse.Kitchen;
            Assert.True(Haskitchen);


            var HasLivingRoom = FluentHouse.LivingRoom;
            Assert.True(HasLivingRoom);

            var Bedroom = FluentHouse.Bedrooms;
            Assert.Equal(4, Bedroom);

        }

    }
}
