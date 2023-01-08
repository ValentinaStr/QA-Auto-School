using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Circle : Figure
	{
		private double _radius;
		public double Radius { get { return _radius;} set { _radius = value; } }
		public Point Center { get; set; }
		
		public Circle(string name, double radius, Point cerner) : base(name)
		{
			Radius = radius;
			Center = cerner;
		}

		public double GetAreaOfCircle()
		{
			return Math.PI * Math.Pow(Radius,2);
		}

	}
}
