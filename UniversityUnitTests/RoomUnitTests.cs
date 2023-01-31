using Microsoft.VisualStudio.TestTools.UnitTesting;
using Building_Linq.RealProperty;

namespace UniversityUnitTests
{
	[TestClass]	
	public class RoomUnitTests
	{
		[TestMethod]
		public void СompareRoomWithTheSameNumberNegative()
		{
			var resaltroom1 = new Room(3,"Room name");
			var resaltroom2 = new Room(3, "Room name");

			Assert.IsTrue(resaltroom1.Equals(resaltroom2));
		}

		[TestMethod]
		public void ССompareRoomWithTheSameNumberPositive()
		{
			var resaltroom1 = new Room(5, "Room name");
			var resaltroom2 = new Room(3, "Room name");

			Assert.IsFalse(resaltroom1.Equals(resaltroom2));
		}

	}
}
