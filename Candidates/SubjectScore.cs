namespace DataTypesIntro.Candidates
{
    public class SubjectScore
    {
        private const int MaxScore = 100;
        public const int MinScore = 0;
        private int _Score;
        public string Subject { get; set; }
        public int Score
        {
            get => _Score;
            set
            {
                if (value >= 0 && value <= MaxScore)
                {
                    _Score = value;
                }
            }
        }

        public SubjectScore(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }
    }
}
