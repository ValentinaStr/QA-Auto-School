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
				if (value < 0) throw new ArgumentException("TaxID mast be positive number");
				_taxId = value;
			}
		}
		public UniversityEmployee(Person employeePerson, int taxId)
		{
			EmployeePerson = employeePerson;
			TaxId = taxId;
		}
		public abstract string GetOfficialDuties();

		public override bool Equals(object obj)
		{
			if (obj == null)
			{ return false; }
				
			var employee = (UniversityEmployee)obj;

			return TaxId == employee.TaxId;
		}

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
