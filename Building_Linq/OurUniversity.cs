using University.Employee;
using University.Candidates;
using Building_LINQ.RealProperty;

namespace Building_LINQ
{
    internal class OurUniversity
	{
		internal Rector Rector { get; set; }
		internal List<UniversityEmployee> AllUniversityEmployees { get; set; }
		internal List<Building> Allbuildings { get; set; }
		public OurUniversity(Rector rector, List<UniversityEmployee> allUniversityEmployees, List<Building> allbuildings)
		{
			Rector = rector;
			AllUniversityEmployees = allUniversityEmployees;
			Allbuildings = allbuildings;
		}
		public bool AddEmployee(UniversityEmployee employeeToAdd)
		{
			if (AllUniversityEmployees.Contains(employeeToAdd))
			{
				return false;
			}
			AllUniversityEmployees.Add(employeeToAdd);
			return true;
		}
		public bool AddBuilding(Building buildingToAdd)
		{
			if (Allbuildings.Contains(buildingToAdd))
			{
				return false;
			}
			Allbuildings.Add(buildingToAdd);
			return true;
		}
	}
}
