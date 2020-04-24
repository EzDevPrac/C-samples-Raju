using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Facade.Test
{
   public class PaymentServiceTest
    {
        [Fact]
        public void MakePaymentTest()
        {
            Assert.True(PaymentService.MakePayment());
        }
    }
}
