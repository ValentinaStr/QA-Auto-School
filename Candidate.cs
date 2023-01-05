namespace DataTypesIntro
{
	internal class Candidate
	{
		public Person Person;
		public SubjectScore[] subjectScore;

		public Candidate(Person person, SubjectScore[] subjectScore)
		{
			this.Person = person;
			this.subjectScore = subjectScore;
		}
	}
}
