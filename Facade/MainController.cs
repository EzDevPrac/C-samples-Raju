using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
     class MainController
    {
        static void Main(string[] args)
        {
            OrderFulfillmentController Controller = new OrderFulfillmentController();
            Controller.facade = new OrderServiceFacadeImpl();
            Controller.OrderProduct(9);
            //bool result = Controller.orderFulfilled;
            //Assert
        }
    }
}
