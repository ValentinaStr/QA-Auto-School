using University.Candidates;
using University.Employee;

namespace Building_Linq
{
	public class Rector : UniversityEmployee
	{
		public Rector(Person employeePerson, int taxID) : base(employeePerson, taxID)
		{

		}
		public override string GetOfficialDuties()
		{
			return $"Rector of the University {EmployeePerson.Name}{EmployeePerson.LastName}";
		}
	}
}
