using University.Candidates;

namespace University.Employee
{
	public abstract class UniversityEmployee : IComparable<UniversityEmployee> 
	{
		private int _taxId;
		public Person EmployeePerson { get; set; }
		public int TaxId
		{
			get { return _taxId; }
			set
			{
				if (value < 0) throw new ArgumentException("Wrong TaxID");
				_taxId = value;
			}
		}
		public UniversityEmployee(Person employeePerson, int taxId)
		{
			EmployeePerson = employeePerson;
			TaxId = taxId;
		}
		public abstract string GetOfficialDuties();


		public int CompareTo(UniversityEmployee? employee)
		{
			if (employee?.EmployeePerson.Name is null|| employee.EmployeePerson.LastName is null)
			{
				throw new ArgumentException("Wrong Name or Lastname");
			}
			return (employee.EmployeePerson.Name.Length + employee.EmployeePerson.LastName.Length)
				   - (EmployeePerson.Name.Length + EmployeePerson.LastName.Length);
		}
	}
}
