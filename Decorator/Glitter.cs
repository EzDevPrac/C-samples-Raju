using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Glitter : FlowerBouquetDecorator
    {
        public FlowerBouquet FlowerBouquet;

        public Glitter(FlowerBouquet FlowerBouquet) 
        {
            this.FlowerBouquet = FlowerBouquet;
        }

        public override string GetDescription()
        {
            return FlowerBouquet.GetDescription() + ", glitter";
        }

        public override double Cost()
        {
            return 4 + FlowerBouquet.Cost();
        }
    }
    }
