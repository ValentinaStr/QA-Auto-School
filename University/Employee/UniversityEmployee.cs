using University.Candidates;

namespace University.Employee
{
	public abstract class UniversityEmployee
	{
		public Person EmployeePerson { get; set; }
		public int TaxId { get; set; }

		public UniversityEmployee(Person employeePerson, int taxID)
		{
			EmployeePerson = employeePerson;
			TaxId = taxID;
		}
		public abstract string GetOfficialDuties();
	}
}
