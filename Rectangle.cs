using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Rectangle: Figure
	{
		public Point[] RectangleAplex { get; set; }

		public Rectangle(string name,Point[] rectanglePoints) : base(name)
		{
			RectangleAplex = rectanglePoints;
		}

		public double GetAreaOfRentangle()
		{
			double area = ((RectangleAplex[1].PointX - RectangleAplex[0].PointX) *
			   (RectangleAplex[2].PointY - RectangleAplex[0].PointY) -
			   (RectangleAplex[2].PointX - RectangleAplex[0].PointX) *
			   (RectangleAplex[1].PointY - RectangleAplex[0].PointY));
			if (area < 0)
			{
				area = area * (-1);
			};
			return area*2;
		}


	}

}
