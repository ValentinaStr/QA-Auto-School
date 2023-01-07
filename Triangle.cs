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
			double perimeter = GetPerimetrTriangle();
			double firstSide = GetSidesFirstLength();
			double secondSide = GetSidesSecondLength();
			double thirdSide = GetSidesThirdLength();
			return Math.Cbrt(perimeter / 2 *
				 (perimeter / 2 - firstSide) *
				 (perimeter / 2 - secondSide) *
				 (perimeter / 2 - thirdSide)
				 );

		}
	}

}