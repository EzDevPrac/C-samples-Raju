using System;
using System.Collections.Generic;
using System.Text;

namespace pairElementprogram
{
    class ControlFactory : ILogicSelector
    {
        public string Logic { get; private set; }

        public string LogicSelector(string logic)
        {
            switch (Logic)
            {
                case "Logic1":
                    IFindpair SumPair = new Logic1();
                    return SumPair.FindPair(int[] A, int sum);

                case "Logic2":
                    IFindpair PairSum = new Logic2();
                    return PairSum.FindPair(int[] A, int sum);

                default:
                    throw new ApplicationException(string.Format("Logic '{0}' cannot be created", Logic));


            }
        }
    }
}
