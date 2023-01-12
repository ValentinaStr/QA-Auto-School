namespace Task_3
{
	public class University
	{
		internal Person Rector { get; set; }
		internal List<UniversityEmployee> AllUniversityEmployees { get; set; }
		internal List<Building> Allbuildings { get; set; }
		public University(Person rector, List<UniversityEmployee> allUniversityEmployees, List<Building> allbuildings)
		{
			Rector = rector;
			AllUniversityEmployees = allUniversityEmployees;
			Allbuildings = allbuildings;
		}
	}
}
