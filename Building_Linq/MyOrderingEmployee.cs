using University.Employee;

namespace Building_Linq
{
	public class MyOrderingEmployee : IComparer<UniversityEmployee>
	{
		public int Compare(UniversityEmployee? prevEmployee, UniversityEmployee? nextEmployee)
		{
			int prevSumLenghtNameLastname = prevEmployee.EmployeePerson.Name.Length + prevEmployee.EmployeePerson.LastName.Length;
			int nextSumLenghtNameLastname = nextEmployee.EmployeePerson.Name.Length + nextEmployee.EmployeePerson.LastName.Length;

			if (nextSumLenghtNameLastname == prevSumLenghtNameLastname)
			{
				return 0;
			}

			if (nextSumLenghtNameLastname < prevSumLenghtNameLastname)
			{
				return -1;
			}
			return 1;
		}
	}
}
