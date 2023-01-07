using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Point
	{
		public char Name { get; set; }
		public int PointX { get; set; }
		public int PointY { get; set; }

		public Point(char name, int pointX, int pointY)
		{
			Name = name;
			PointX = pointX;
			PointY = pointY;
		}
	}
}
