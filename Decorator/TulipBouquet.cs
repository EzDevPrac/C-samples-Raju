using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TulipBouquet : FlowerBouquet 
    {
        public TulipBouquet()
        {
            Description = "Tulip bouquet";
        }

        public override double Cost()
        {
            return 30.0;
        }
    }
}
