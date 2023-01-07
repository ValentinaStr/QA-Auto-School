using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Rectangle
	{
		public string Name { get; set; }
		public Point[] RectanglePoints { get; set; }

		public Rectangle(string name, Point[] rectanglePoints)
		{
			Name = name;
			RectanglePoints = rectanglePoints;
		}
	}
}
