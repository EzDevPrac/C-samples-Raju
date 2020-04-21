using System;
using Xunit;

namespace Facade.Test
{
    public class OrderFulfillment
    {
        [Fact]
        public void OrderStatus()
        {
            OrderFulfillmentController Controller = new OrderFulfillmentController();
            Controller.facade = new OrderServiceFacadeImpl();
            string expected = Controller.OrderProduct(9);
            Assert.Equal("OrderFulfillmentController: Order fulfillment completed.", expected);

        }
    }
}
