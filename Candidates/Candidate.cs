namespace DataTypesIntro.Candidates
{
    public class Candidate
    {
        public Person Person { get; set; }
        public SubjectScore[] SubjectScore { get; set; }

        public Candidate(Person person, SubjectScore[] subject_score)
        {
            Person = person;
            SubjectScore = subject_score;
        }

        public int GetScoreSubject(string sabjectName)
        {
            foreach (SubjectScore SabjectAndScore in SubjectScore)
            {
                if (SabjectAndScore.Subject == sabjectName)
                {
                    return SabjectAndScore.Score;
                }
            }
            return 0;
        }

        public string GetStreet()
        {
            return Person.Address.Street;
        }
    }
}
