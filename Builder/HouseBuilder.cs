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
                this.floors = value;
                return this;
            }

            public HouseBuilder Bedrooms(int value)
            {
                this.bedrooms = value;
                return this;
            }

            public HouseBuilder HasLivingRoom()
            {
                this.livingroom = true;
                return this;
            }
            public HouseBuilder HasKitchen()
            {
                this.kitchen = true;
                return this;
            }

            public HouseBuilder Roof(string value)
            {
                this.roof = value;
                return this;
            }

        public House Build()
            {
                var house = new House();
                house.Floors = this.floors;
                house.Bedrooms = this.bedrooms;
                house.LivingRoom = this.livingroom;
                house.Kitchen = this.kitchen;
                house.Roof = this.roof;
                return house;
            }
        }
    }
