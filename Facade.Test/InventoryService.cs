using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Facade.Test
{
   public class InventoryServiceTest
    {
        [Fact]

        public void IsAvailableTest()
        {
            Product product = new Product();
            Assert.True( InventoryService.IsAvailable(product));
        }
    }
}
