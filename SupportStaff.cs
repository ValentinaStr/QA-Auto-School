using DataTypesIntro.Candidates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
