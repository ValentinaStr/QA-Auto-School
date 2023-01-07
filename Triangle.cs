namespace DataTypesIntro
{

	internal class Triangle : Figure
	{
		public Point[] TriangleApex { get; set; }

		public Triangle(string name, Point[] triangleApex) : base(name)
		{
			TriangleApex = triangleApex;
		}

		//First.TriangleApex[0].GetDistanse(First.TriangleApex[1])
	}
}