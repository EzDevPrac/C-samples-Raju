using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
   public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildStructure();
        void BuildRoof();
        void PaintHouse();
        void FurnishHouse();
        House GetHouse();
    }
}
