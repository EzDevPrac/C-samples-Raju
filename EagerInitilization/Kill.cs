using System;

namespace EagerInitilization
{
    public class Kill
    {
        public int KillEnemy()
        {
            int killingScore = 0;
            Console.WriteLine("Enter the number of emenies");
            int NEnemy = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < NEnemy; i++)
            {
                Console.WriteLine(i + " Enemy killed");
                killingScore++;
            }
            return killingScore;
        }
    }
}