using DataTypesIntro;

Triangle First = new Triangle("First",
	new Point[]{
		new Point(20, 30),
		new Point(10, 40),
		new Point(20,15)
	}
);
Console.WriteLine(First.GetAreaOfTriangle());
