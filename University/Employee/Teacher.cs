namespace University
{
	internal class Teacher : UniversityEmployee
	{
		public Course CourseName { get; set; }

		public Teacher(Person employeePerson, int taxID, Course courseName) : base(employeePerson, taxID)
		{
			CourseName = courseName;
		}

		public override string GetOfficialDuties()
		{
			return $"{EmployeePerson.Name}{EmployeePerson.LastName}, course is {CourseName.Name}";
		}
	}
}
