using University.Employee;
using Building_Linq.RealProperty;

namespace Building_Linq
{
    public class OurUniversity
	{
		public Rector Rector { get; set; }
		public List<UniversityEmployee> AllUniversityEmployees { get; set; }
		public List<Building> Allbuildings { get; set; }
		public OurUniversity(Rector rector, List<UniversityEmployee> allUniversityEmployees, List<Building> allbuildings)
		{
			Rector = rector;
			AllUniversityEmployees = allUniversityEmployees;
			Allbuildings = allbuildings;
		}
		public void AddEmployee(UniversityEmployee employeeToAdd)
		{
			if (!AllUniversityEmployees.Contains(employeeToAdd))
			{
				AllUniversityEmployees.Add(employeeToAdd);
			}
		}
		public void AddBuilding(Building buildingToAdd)
		{
			if (!Allbuildings.Contains(buildingToAdd))
			{
				Allbuildings.Add(buildingToAdd);
			}
		}
	}
}
