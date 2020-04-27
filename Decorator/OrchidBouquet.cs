using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public class OrchidBouquet : FlowerBouquet
    {

        public OrchidBouquet()
        {
            Description = "Orchid bouquet";
        }


        public override double Cost()
        {
            return 29.0;
        }
    }
}
