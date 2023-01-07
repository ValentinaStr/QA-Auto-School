using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Circle
	{
		private int _radius;
		public string Name { get; set; }
		public int Radius { get { return _radius;} set { _radius = value; } }

		public Circle(string name, int radius)
		{
			Name = name;
			Radius = radius;
		}
	}
}
