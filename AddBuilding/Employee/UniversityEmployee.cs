using System.Xml.Linq;

namespace AddBuilding
{
	public abstract class UniversityEmployee
	{
		public Person EmployeePerson { get; set; }
		public int TaxID { get; set; }

		public UniversityEmployee(Person employeePerson, int taxID)
		{
			EmployeePerson = employeePerson;
			TaxID = taxID;
		}
		public abstract string GetOfficialDuties();

		public override bool Equals(object? obj)
		{
			UniversityEmployee? employee = obj as UniversityEmployee;

			if (employee != null)
			{
				return employee.TaxID == TaxID;
			}
			return false;
		}
		
	}
}
