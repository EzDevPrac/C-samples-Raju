using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
   public class Product
    {
        public int pId;
        public string pName;
        public Product() { }
        public Product(int pId, string pName)
        {
            this.pId = pId;
            this.pName = pName;
        }
    }
    
}
