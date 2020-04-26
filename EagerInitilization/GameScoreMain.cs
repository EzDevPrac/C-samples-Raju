using System;

namespace EagerInitilization
{
    class GameScoreMain
    {
        static void Main(string[] args)
        {

            ScoreManager scoreManager = ScoreManager.GetInstance();

            scoreManager.StartRunning();
            scoreManager.StartKilling();
        }
    }
}
