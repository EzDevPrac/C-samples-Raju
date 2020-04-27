using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class FlowerBouquet
    {
        public string Description;

        public virtual string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
    }
}
