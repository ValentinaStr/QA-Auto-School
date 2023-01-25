using University.Candidates;

namespace University.Employee
{
	public abstract class UniversityEmployee : IComparable<UniversityEmployee> 
	{
		public Person EmployeePerson { get; set; }
		public int TaxId { get; set; }

		public UniversityEmployee(Person employeePerson, int taxId)
		{
			EmployeePerson = employeePerson;
			if (taxId < 0)
			{
				throw new ArgumentException("Wrong TaxID");
			}
			else TaxId = taxId;
		}
		public abstract string GetOfficialDuties();

		public int CompareTo(UniversityEmployee? employee)
		{
			if (this.EmployeePerson.Name is null || employee?.EmployeePerson.Name is null
				|| this.EmployeePerson.LastName is null || employee.EmployeePerson.LastName is null)
			{
				throw new ArgumentException("Wrong Name or Lastname");
			}
			return (employee.EmployeePerson.Name.Length + employee.EmployeePerson.LastName.Length)
				   - (this.EmployeePerson.Name.Length + this.EmployeePerson.LastName.Length);
		}
	}
}
