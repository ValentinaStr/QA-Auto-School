namespace DataTypesIntro.Candidates
{
    public class SubjectScore
    {
        public const int MaxScore = 100;
        public const int MinScore = 0;
        private int _score;
        public string Subject { get; set; }
        public int Score
        {
            get => _score;
            set
            {
                if (value >= MinScore && value <= MaxScore)
                {
                    _score = value;
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
