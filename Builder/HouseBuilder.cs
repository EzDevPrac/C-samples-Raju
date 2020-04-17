using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    
        public class HouseBuilder
        {
            public int floors;
            public int bedrooms;
            public bool livingroom;
            public bool kitchen;
            public string roof;

            public HouseBuilder Floors(int value)
            {
               floors = value;
                return this;
            }

            public HouseBuilder Bedrooms(int value)
            {
                bedrooms = value;
                return this;
            }

            public HouseBuilder HasLivingRoom()
            {
                livingroom = true;
                return this;
            }
            public HouseBuilder HasKitchen()
            {
                kitchen = true;
                return this;
            }

            public HouseBuilder Roof(string value)
            {
                roof = value;
                return this;
            }

        public House Build()
            {
                var house = new House();
                house.Floors = floors;
                house.Bedrooms = bedrooms;
                house.LivingRoom = livingroom;
                house.Kitchen = kitchen;
                house.Roof = roof;
                return house;
            }
       
    }
    }
