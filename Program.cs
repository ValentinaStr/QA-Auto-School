using DataTypesIntro;
using System;
using System.Xml.Linq;

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
	new Point(-3,2),
	new Point(4,2),
	new Point(4,-2),
	new Point(-3,-2)
	}
);

Figure[] allFigures = { First, FirstCircle, FirstRectangle};


double sumArea = 0;
foreach (Figure element in allFigures)
{
	sumArea += element.GetArea();
}

Console.WriteLine(sumArea);

//Console.WriteLine(FirstRectangle.GetArea());