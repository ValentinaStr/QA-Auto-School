using DataTypesIntro.Candidates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Teacher : UniversityEmployee
	{ 
		public Course CourseName { get; set; }

		public Teacher(Course courseName, Person employeePerson, int taxID) : base(employeePerson, taxID)
		{
			CourseName = courseName;
		}

		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name}{EmployeePerson.LastName}, course is {CourseName}";
		}
	}
}
