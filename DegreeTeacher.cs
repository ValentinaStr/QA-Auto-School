using DataTypesIntro.Candidates;

namespace DataTypesIntro
{
	internal class DegreeTeacher : Teacher
	{
		public string Degree { get; set; }
		public string Title { get; set; }

		public DegreeTeacher(Person employeePerson, int taxID, Course courseName, string degree, string title) :
			base(employeePerson, taxID, courseName)
		{
			Degree = degree;
			Title = title;
		}

		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name} {EmployeePerson.LastName} scientific degree: {Degree} teacher title is {Title}, course: {CourseName.Name}";
		}
	}
}
