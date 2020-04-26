using System;

namespace EagerInitilization
{
    internal sealed class ScoreManager
    {

        private int ScoreCount = 0;

        private  static readonly ScoreManager INSTANCE = new ScoreManager();

        private ScoreManager() { }

        public static ScoreManager GetInstance()
        {
            return INSTANCE;
        }

        private static readonly int numTracks = 1;


            public void StartRunning()
            {
                int RunningScore = 0;

                for (int i = 0; i < numTracks; ++i)
                {
                    Track Track = new Track();
                Track.Start();
                }
                ScoreCount += RunningScore;
            }

            public void StartKilling()
            {
                Kill kill = new Kill();
                ScoreCount += kill.KillEnemy();
                Console.WriteLine(ScoreCount);
            }
        }
}