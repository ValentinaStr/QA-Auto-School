using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
	internal class Circle
	{
		private int _radius;
		public int Radius { get { return _radius;} set { _radius = value; } }

		public Circle(int radius)
		{
			Radius = radius;
		}
	}
}
