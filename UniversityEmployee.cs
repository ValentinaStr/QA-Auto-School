using DataTypesIntro.Candidates;

namespace DataTypesIntro
{
	internal abstract class UniversityEmployee
	{
		public Person EmployeePerson { get; set; }
		public int TaxID { get; set; }

		public UniversityEmployee(Person employeePerson, int taxID)
		{
			EmployeePerson = employeePerson;
			TaxID = taxID;
		}
		public abstract string GetOfficialDuties();
	}
}
