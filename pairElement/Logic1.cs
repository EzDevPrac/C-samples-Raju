using System;
using System.Collections.Generic;
using System.Text;

namespace pairElementprogram
{
    public class Logic1 : IFindpair
    {
        public void FindPair(int[] A, int sum)  //Logic_1
        {
            int count = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] + A[j] == sum)
                    {
                        Console.WriteLine("Pair found for the given sum of the element is {0} and {1}", A[i], A[j]);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No pair found");
            }
            else
            {
                return;
            }

        }
    }
}
