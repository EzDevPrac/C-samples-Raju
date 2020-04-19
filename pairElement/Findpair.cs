using System;
using System.Collections.Generic;
using System.Text;

namespace pairElementprogram
{

    public interface IFindpair
    {
        public void FindPair(int[] A, int sum);
    }
    public interface ILogicSelector
    {
        public string LogicSelector(string logic);
    }
}
