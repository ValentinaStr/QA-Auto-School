using University.Employee;

namespace Building_Linq
{
	public class MyOrderingEmployee : IComparer<UniversityEmployee>
	{
		public int Compare(UniversityEmployee? prevEmployee, UniversityEmployee? nextEmployee)
		{
			if (prevEmployee == null && nextEmployee == null)
			{
				return 0;
			}
			else if (prevEmployee!= null && nextEmployee == null)
			{
				return 1;
			}
			else if(prevEmployee == null && nextEmployee != null) 
			{
				return -1;
			}
			return nextEmployee.EmployeePerson.LenghtNameLastName - prevEmployee.EmployeePerson.LenghtNameLastName;
		}
	}
}
