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
		//S = (|(х0 - х1)(у0 + у1) +
		//(х1 - х2)(у1 + у2) +
		//(х2 - х3)(у2 + у3)
		//+ (х3 - х0)(у3 + у0)|) / 2.

		//S = (|(х1 - х2)(у1 + у2) + (х2 - х3)(у2 + у3) + (х3 - х4)(у3 + у4) + (х4 - х1)(у4 + у1)|) / 2.
		public override double GetArea()
		{
			double area = ((RectangleAplex[0].PointX - RectangleAplex[1].PointX) * (RectangleAplex[0].PointY + RectangleAplex[1].PointY) +
			   (RectangleAplex[1].PointX - RectangleAplex[2].PointX) * (RectangleAplex[1].PointY + RectangleAplex[2].PointY) +
			   (RectangleAplex[2].PointX - RectangleAplex[3].PointX) * (RectangleAplex[2].PointY + RectangleAplex[3].PointY) +
			   (RectangleAplex[3].PointX - RectangleAplex[0].PointX) * (RectangleAplex[3].PointY + RectangleAplex[0].PointY));

			if (area < 0)
			{
				area = area * (-1);
			};
			return area/2;
		}


	}

}
