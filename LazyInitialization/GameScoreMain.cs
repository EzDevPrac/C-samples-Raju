using System;

namespace LazyInitialization
{
    class GameScoreMain
    {
        
            public static void Main(string[] args)
            {
                //ScoreManager.Kill

                ScoreManager scoreManager = ScoreManager.GetInstance();

                scoreManager.StartRunning();
                scoreManager.StartKilling();


            }
        
    }
}
