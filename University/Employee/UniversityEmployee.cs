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
			if (obj == null) return false;

			return obj is UniversityEmployee employee
				&& employee != null
				&& employee.TaxId == TaxId;
		}

		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}
	}
}
