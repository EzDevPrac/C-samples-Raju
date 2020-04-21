using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class OrderServiceFacadeImpl : IOrderServiceFacade
    {
        public bool PlaceOrder(int pId)
        {
            bool orderFulfilled = false;
            Product product = new Product
            {
                pId = pId
            };


            if (InventoryService.IsAvailable(product))
            {
                Console.WriteLine("Product with ID: " + product.pId + " is available.");
            }
            bool paymentconfirmed = PaymentService.MakePayment();
            if(paymentconfirmed)
            {
                Console.WriteLine("Payment confirmed...");
                Console.WriteLine(ShippingService.ShipProduct(product));
                orderFulfilled = true;
            }
            return orderFulfilled;
        }
    }
}
