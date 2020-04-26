using System;

namespace SpriralMatrix
{
    public class SpiralMatrix
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("No of rows");
            int NRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No of columns");
            int NColumn = Convert.ToInt32(Console.ReadLine());

            int[,] Arry = new int[NRows,NColumn];
            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumn; j++)
                {
                     Arry[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            SpriralMatrix(Arry,
                          NColumn,
                          NRows);
        }


        public static void SpriralMatrix(int[,] arry, int nColumn, int nRows)
        {
            int Srow = 0;
            int Scolumn = 0;
            int Ncolumn = nColumn-1;
            int Nrow = nRows - 1;

            while(Srow < Nrow && Scolumn < Ncolumn)
            {
                for (int i = Scolumn; i <= Ncolumn; ++i)
                {
                    Console.WriteLine("Array[{0}{1}] = {2}",Srow,i,arry[Srow,i]);
                }
                Srow++;

                for (int i = Srow; i <= Nrow; ++i)
                {
                    Console.WriteLine("Array[{0}{1}] = {2}",i,Ncolumn,arry[i, Ncolumn]);
                }
                Ncolumn--;
                if(Srow < Nrow)
                { 
                for (int i = Ncolumn; i >= Scolumn ; --i)
                {
                    Console.WriteLine("Array[{0}{1}] = {2}",Nrow,i,arry[Nrow, i]);
                }
                Nrow--;
                }
                if (Scolumn < Ncolumn)
                {

                    for (int i = Nrow; i >= Srow; --i)
                    {
                        Console.WriteLine("Array[{0}{1}] = {2}", i, Scolumn, arry[i, Scolumn]);
                    }
                    Scolumn++;
                }

            }
        }


    }



}
