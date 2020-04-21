using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class InventoryService
    {
        public static bool IsAvailable(Product product)
        {
            return true;
        }
    }
}
