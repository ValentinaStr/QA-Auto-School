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

		public override bool Equals(object? obj)
		{
			if (obj != null && obj is UniversityEmployee employee) return TaxId == employee.TaxId;
			return false;
		}
		public override int GetHashCode() => TaxId.GetHashCode();

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
