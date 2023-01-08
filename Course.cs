using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Course
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public Course(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}
