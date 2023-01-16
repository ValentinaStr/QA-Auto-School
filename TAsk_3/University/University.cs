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

		/*public bool AddEmployee(List<UniversityEmployee> AllUniversityEmployees, UniversityEmployee newEmployee)
		{
			foreach (UniversityEmployee employee in AllUniversityEmployees) 
			{
				if (employee.Equals(newEmployee))
				{
					return false;
				}				
			}
			AllUniversityEmployees.Add(newEmployee);
			return true;
		}*/

		public bool AddSame<T>(List<T> items, T itemsToChek)
		{ 
			foreach (T item in items)
			{
				if(item.Equals(itemsToChek)) return false;
			}
			items.Add(itemsToChek); return true;
		}
	}
}
