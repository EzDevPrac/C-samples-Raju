using System;



namespace LazyInitialization
{
    public class ScoreManager
    {
        private static ScoreManager instance = null;
        public int ScoreCount = 0;
        private ScoreManager() { }
        public static ScoreManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ScoreManager();
            }

            return instance;
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