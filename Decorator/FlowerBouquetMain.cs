using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
     class FlowerBouquetMain
    {
         static void Main(string[] args)
        {

            {
              
                FlowerBouquet TulipBouquet = new TulipBouquet();
                Console.WriteLine(TulipBouquet.GetDescription() + " $ " + TulipBouquet.Cost());

                FlowerBouquet OrchidBouquet = new OrchidBouquet();
                Console.WriteLine(OrchidBouquet.GetDescription() + " $ " + OrchidBouquet.Cost());

                
                
                FlowerBouquet DecoratedTulipBouquet = new TulipBouquet();
                DecoratedTulipBouquet = new Glitter(DecoratedTulipBouquet);
                DecoratedTulipBouquet = new PaperWrapper(DecoratedTulipBouquet);
               
                Console.WriteLine(DecoratedTulipBouquet.GetDescription() + " $ " + DecoratedTulipBouquet.Cost());





                FlowerBouquet DecoratedOrchidBouquet = new OrchidBouquet();
                DecoratedOrchidBouquet = new PaperWrapper(DecoratedOrchidBouquet);
                DecoratedOrchidBouquet = new Glitter(DecoratedOrchidBouquet);

                Console.WriteLine(DecoratedOrchidBouquet.GetDescription() + " $ " + DecoratedOrchidBouquet.Cost());
            }
        }
    }
}
