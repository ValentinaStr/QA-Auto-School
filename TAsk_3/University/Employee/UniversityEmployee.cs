using System.Xml.Linq;

namespace Task_3
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
			if (obj is UniversityEmployee)
			{
				UniversityEmployee? employee = obj as UniversityEmployee;
				if (employee != null)
				{
					return employee.TaxID.Equals(TaxID);
				}
			}
		 return false;
		}
		public override int GetHashCode() => TaxID.GetHashCode();
	}
}
