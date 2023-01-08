using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Teacher : UniversityEmployee
	{
		public Course Course { get; set; }

		public Teacher(employeePerson, taxID, Course course) : base(employeePerson, taxID)
		{
			Course = course;
		}
	}
}
