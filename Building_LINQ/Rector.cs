using University.Candidates;
using University.Employee;

namespace Building_LINQ
{
	public class Rector : UniversityEmployee
	{
		public Rector(Person employeePerson, int taxID) : base(employeePerson, taxID)
		{

		}
		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name}{EmployeePerson.LastName}";
		}
	}

}
