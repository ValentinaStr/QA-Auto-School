namespace DataTypesIntro
{
	internal class Triangle : Figure
	{
		public Point[] TriangleApex { get; set; }

		public Triangle(string name, Point[] triangleApex) : base(name)
		{
			TriangleApex = triangleApex;
		}

		public double GetSidesFirstLength()
		{
			return TriangleApex[0].GetDistanse(TriangleApex[1]);
		}
		public double GetSidesSecondLength()
		{
			return TriangleApex[1].GetDistanse(TriangleApex[2]);
		}
		public double GetSidesThirdLength()
		{
			return TriangleApex[2].GetDistanse(TriangleApex[0]);
		}

		public double GetPerimetrTriangle()
		{
			double firstSide = GetSidesFirstLength();
			double secondSide = GetSidesSecondLength();
			double thirdSide = GetSidesThirdLength();
			return firstSide + secondSide + thirdSide;
		}

		
		public double GetAreaOfTriangle()
		{
			double c = ((TriangleApex[1].PointX - TriangleApex[0].PointX) *
			   (TriangleApex[2].PointY - TriangleApex[0].PointY) -
			   (TriangleApex[2].PointX - TriangleApex[0].PointX) *
			   (TriangleApex[1].PointY - TriangleApex[0].PointY));
			if (c < 0)
			{
				c = c * (-1);
			};
			return c / 2;
		}
	}


}