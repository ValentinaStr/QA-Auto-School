namespace DataTypesIntro
{
	internal class SubjectScore
	{
		public string Subject { get; set; }
		public int Score { get; set; }

		public SubjectScore(string subject, int score)
		{
			this.Subject = subject;
			this.Score = score;
		}
	}
}
