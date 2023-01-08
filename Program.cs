using DataTypesIntro;
using System;

Triangle First = new Triangle("First",
	new Point[]{
		new Point(20, 30),
		new Point(10, 40),
		new Point(20,15)
	}
);
Circle FirstCircle = new Circle("FirstCircle", 25, new Point(2, 2));


Rectangle FirstRectangle = new Rectangle("FirstRectangle",
	new Point[]{
	new Point(-3,-1),
	new Point(-3,-3),
	new Point(5,-1),
	new Point(5,3)
	}
);

Console.WriteLine(First.GetAreaOfTriangle());

Console.WriteLine(FirstCircle.GetAreaOfCircle());

Console.WriteLine(FirstRectangle.GetAreaOfRentangle());