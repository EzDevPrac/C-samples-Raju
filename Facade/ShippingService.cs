using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class ShippingService
    {
        public static string ShipProduct(Product product)
        {
            return "Product has been shiped";
        }
    }
}
