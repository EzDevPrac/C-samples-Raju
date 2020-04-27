using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{ 
    public abstract class FlowerBouquetDecorator : FlowerBouquet
    {
        public override string GetDescription()
        {
            return Description;
        }
    }

}
