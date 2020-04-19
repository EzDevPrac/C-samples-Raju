using System;
using System.Collections.Generic;
using System.Text;

namespace pairElementprogram
{
    class Logic2 : IFindpair
    {
        public void FindPair(int[] A, int sum)
        {
            Array.Sort(A);
            int lt = 0;
            int count = 0;
            int rt = A.Length - 1;
            while(lt < rt)
            {
                if(A[lt] + A[rt] == sum)
                {
                    Console.WriteLine("Pair found for the given sum of the element is {0} and {1}", A[lt], A[rt]);
                    lt++;
                    count++;
                }
                else if (A[lt] + A[rt] < sum)
                {
                    lt++;
                }
                else
                {
                    rt--;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No pair found");
            }


          //  throw new NotImplementedException();
        }
    }
}
