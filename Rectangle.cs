using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Rectangle: Figure
	{
		public Point[] RectanglePoints { get; set; }

		public Rectangle(Point[] rectanglePoints, string name) 
			: base(name)
		{
			RectanglePoints = rectanglePoints;
		}
	}
}
