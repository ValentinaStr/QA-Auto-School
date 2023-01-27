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

		public override string ToString()
		{
			return EmployeePerson.Name + " " +  EmployeePerson.LastName;
		}

		public int CompareTo(UniversityEmployee? employee)
		{
			if (employee == null)
			{
				return -1;
			}
			return employee.EmployeePerson.LenghtNameLastName - EmployeePerson.LenghtNameLastName;
		}
	}
}
