using DataTypesIntro;
using DataTypesIntro.Candidates;

namespace Task_3
{
	internal class University
	{
		internal Person Rector { get; set; }
		internal UniversityEmployee[] AllUniversityEmployees { get; set; }
		internal Building[] Allbuildings { get; set; }
		public University(Person rector, UniversityEmployee[] allUniversityEmployees, Building[] allbuildings)
		{
			Rector = rector;
			AllUniversityEmployees = allUniversityEmployees;
			Allbuildings = allbuildings;
		}
	}
}
