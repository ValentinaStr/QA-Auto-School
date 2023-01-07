using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Point
	{
		public int PointX { get; set; }
		public int PointY { get; set; }

		public Point(int pointX, int pointY)
		{
			PointX = pointX;
			PointY = pointY;
		}
		public double GetDistanse(Point Second)
		{
			double distance = Math.Cbrt(Math.Pow((Second.PointX - PointX), 2)
										+ Math.Pow((Second.PointY - PointY), 2));
			return distance;
		}
	}
}
