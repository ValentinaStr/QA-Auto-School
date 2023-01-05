namespace DataTypesIntro
{
	public class Candidate
	{
		public Person Person { get;  set; }
		public SubjectScore[] SubjectScore { get; set; }

		public Candidate(Person person, SubjectScore[] subject_score)
		{
			Person = person;
			SubjectScore = subject_score;
		}
		
		public int GetMaxScore(string SabjectName)
		{
			foreach (SubjectScore SabjectAndScore in SubjectScore)
			{
				if (SabjectAndScore.Subject == SabjectName)
				{
					return SabjectAndScore.Score;
				}
			}	

			return 0;
		}
	}
}
