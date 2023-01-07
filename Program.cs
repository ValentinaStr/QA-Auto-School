using DataTypesIntro;

Triangle First = new Triangle("First",
	new Point[]{
		new Point(20, 30),
		new Point(10, 40),
		new Point(20,15)
	}
);
Console.WriteLine(GetAreaOfTriangle(First));

double GetSidesFirstLength(Triangle one)
{
	return one.TriangleApex[0].GetDistanse(one.TriangleApex[1]);
}

double GetSidesSecondLength(Triangle one)
{
	return one.TriangleApex[1].GetDistanse(one.TriangleApex[2]);
}

double GetSidesThirdLength(Triangle one) 
{
	return one.TriangleApex[2].GetDistanse(one.TriangleApex[0]);
}

double GetPerimetrTriangle(Triangle one)
{
	double firstSide = GetSidesFirstLength(one);
	double secondSide = GetSidesSecondLength(one);
	double thirdSide = GetSidesThirdLength(one);
	 return firstSide + secondSide + thirdSide;
}

double GetAreaOfTriangle(Triangle one)
{
	double perimeter = GetPerimetrTriangle(one);
	double firstSide = GetSidesFirstLength(one);
	double secondSide = GetSidesSecondLength(one);
	double thirdSide = GetSidesThirdLength(one);
	return   Math.Cbrt(perimeter / 2 * 
		 (perimeter / 2 - firstSide) * 
		 (perimeter / 2 - secondSide) * 
		 (perimeter / 2 - thirdSide)
		 );

}