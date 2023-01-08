namespace DataTypesIntro
{
	public class Figure
	{
		public string Name { get; set; }
				
		public Figure(string name)
		{
			Name = name;
		}

		public virtual double GetArea()
		{
			return 0;
		}

	}
}
