using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
   public class OrderFulfillmentController
    {
        public IOrderServiceFacade facade;
        public bool orderFulfilled = false;
        public string OrderProduct(int pId)
        {
            orderFulfilled = facade.PlaceOrder(pId);
            return "OrderFulfillmentController: Order fulfillment completed.";
        }
    }
}
