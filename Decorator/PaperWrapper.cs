using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PaperWrapper : FlowerBouquetDecorator
    {
        public FlowerBouquet FlowerBouquet;

        public PaperWrapper(FlowerBouquet FlowerBouquet) 
        {
            this.FlowerBouquet = FlowerBouquet;
        }
        public override double Cost()
        {
            return 3 + FlowerBouquet.Cost();
        }

        public override string GetDescription()
        {
            return FlowerBouquet.GetDescription() + ", paper wrap";
        }
    }
}
