using pairElementprogram;
using System;
using System.Collections.Generic;

namespace FindPair.Array
{
    class Program
    {


        public static void Main(string[] args)
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


            Console.WriteLine("Enter the type:Logic1/Logic2");
            string logic = Console.ReadLine();

            ILogicSelector Logic = new ControlFactory();
            Logic.LogicSelector(logic);

            //IFindpair SumPair = new Logic2();
            //Logic.SumPair.FindPair(Input, sum);
        }

       
        //public static void FindPair(int[] A, int sum)
        //{
        //    Array.Sort(A);



        //}


    }
   
}

    
