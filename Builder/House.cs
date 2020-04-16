using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class House
    {

        public int Floor { get; set; }
        public int Bedrooms { get; set; }
        public bool LivingRoom { get; set; }
        public bool Kitchen { get; set; }
        public string Roof { get; set; }
        public int Floors { get; internal set; }

        public House()
        {
            Bedrooms = Bedrooms;
            LivingRoom = LivingRoom;
            this.Kitchen = Kitchen;
            Roof = Roof;
            Floor = Floor;

        }
    }
}
