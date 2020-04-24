using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Facade;

namespace Facade.Test
{
   public class ShippingServicetest
    {
        [Fact]
        public void ShipProductTest()
        {
            Product product = new Product();
           string expected =  ShippingService.ShipProduct(product);
            Assert.Equal("Product has been shiped", expected);
        }
    }
}
