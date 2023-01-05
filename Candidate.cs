namespace DataTypesIntro
{
	public class Candidate
	{
		public Person Person { get;  set; }
		public SubjectScore[] SubjectScore;

		public Candidate(Person person, SubjectScore[] subject_score)
		{
			Person = person;
			SubjectScore = subject_score;
		}
	}
}
