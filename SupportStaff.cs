using DataTypesIntro.Candidates;

namespace DataTypesIntro
{
	internal class SupportStaff : UniversityEmployee
	{

		public string Name { get; set; }
		public string Duties { get; set; }

		public SupportStaff(Person employeePerson, int taxID, string name, string duties) : base (employeePerson, taxID)
		{
			Name = name;
			Duties = duties;
		}
		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name} {EmployeePerson.LastName} {Name} {Duties}";
		}
	}


}
