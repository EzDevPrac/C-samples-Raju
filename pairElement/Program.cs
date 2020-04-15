using System;

namespace FindPair.Array
{
    class Program
    {


        static void Main(string[] args)
        {
            int nElement;
            int sum;
            Console.WriteLine("Enter the size of input elements");
            nElement = Convert.ToInt32(Console.ReadLine());
            int[] Input = new int[nElement];
            for (int i = 0; i < nElement; i++)
            {
                Input[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the sum element");
            sum = Convert.ToInt32(Console.ReadLine());
            findPair(Input, sum);
        }

        public static void findPair(int[] A, int sum)  //Logic_1
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
            if(count == 0)
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

    
