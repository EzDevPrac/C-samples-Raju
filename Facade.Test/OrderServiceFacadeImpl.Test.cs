using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Facade.Test
{
    public class OrderServiceImpl
    {
        [Fact]
        public void OrderServiceIMP()
        {

            OrderFulfillmentController Controller = new OrderFulfillmentController();
            Controller.facade = new OrderServiceFacadeImpl();
            bool expected = Controller.facade.PlaceOrder(9);
            Assert.True(expected);
        }
    }
}
