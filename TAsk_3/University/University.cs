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
		public static bool AddUnique<T>(List<T> items, T itemsToChek)
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
		}
	}
}
