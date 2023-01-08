using DataTypesIntro.Candidates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class UniversityEmployee
	{
		private int _taxID;
		public Person EmployeePerson { get; set; }
		public int TaxID { get; set; }

		public UniversityEmployee(Person employeePerson, int taxID)
		{
			EmployeePerson = employeePerson;
			TaxID = taxID;
		}
		public virtual string GetOfficialDuties()
		{
			return ($"{EmployeePerson.Name} {EmployeePerson.LastName}");
		}
	}
}
