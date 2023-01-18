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
		
		public bool AddEmployee(UniversityEmployee employeeToAdd)
		{
			foreach (var employee in AllUniversityEmployees)
			{
				if (employeeToAdd.Equals(employee))
				{
					return false;
				}
			}
			AllUniversityEmployees.Add(employeeToAdd);
			return true;
		}

		public bool AddBuilding(Building buildingToAdd)
		{
			foreach (var building in AllUniversityEmployees)
			{
				if (buildingToAdd.Equals(building))
				{
					return false;
				}
			}
			Allbuildings.Add(buildingToAdd);
			return true;
		}

		/*public static bool AddUnique<T>(List<T> items, T itemsToChek)
		{
			foreach (T item in items)
			{
				if (item != null && !item.Equals(itemsToChek))
				{
					items.Add(itemsToChek);
					return true;
				}
			}
			return false;
		}*/

	}
}
