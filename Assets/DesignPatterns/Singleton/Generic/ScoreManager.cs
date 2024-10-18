namespace Singleton
{
    public class ScoreManager : GenericSingleton<ScoreManager>
    {
        public int Score { get; private set; }

        public void IncreaseScore(int value)
        {
            Score += value;
        }

        public void DecreaseScore(int value)
        {
            Score -= value;
        }
    }
}
