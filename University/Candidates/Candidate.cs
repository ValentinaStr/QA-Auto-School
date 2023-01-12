namespace University
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

        public int GetScoreSubject(string subjectName)
        {
            foreach (SubjectScore SubjectAndScore in SubjectScore)
            {
                if (SubjectAndScore.Subject == subjectName)
                {
                    return SubjectAndScore.Score;
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
