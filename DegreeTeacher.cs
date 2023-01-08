using DataTypesIntro.Candidates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class DegreeTeacher : Teacher
	{
		public string Degree { get; set; }
		public string Title { get; set; }

		public DegreeTeacher(string degree, string title, Course courseName, Person employeePerson, int taxID) :
			base(courseName, employeePerson, taxID)
		{
			Degree = degree;
			Title = title;
		}

		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name} {EmployeePerson.LastName} scientific degree: {Degree} teacher title is {Title}, course: {CourseName}";
		}

	}
}
