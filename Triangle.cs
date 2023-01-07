using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Triangle
	{
		public string Name { get; set; }
		public Point [] TrianglePoint { get; set; }

		public Triangle(string name, Point[] trianglePoint)
		{
			Name = name;
			TrianglePoint = trianglePoint;
		}
	}
}
