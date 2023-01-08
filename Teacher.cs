using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Teacher
	{ 
		public Course Course { get; set; }

		public Teacher(Course course) 
		{
			Course = course;
		}
	}
}
