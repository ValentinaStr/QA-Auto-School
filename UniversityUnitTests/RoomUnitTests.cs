using Microsoft.VisualStudio.TestTools.UnitTesting;
using Building_Linq.RealProperty;

namespace UniversityUnitTests
{
	[TestClass]	
	public class RoomUnitTests
	{
		[TestMethod]
		public void СompareRoomWithTheSameNumberPositive()
		{
			var resultRoom1 = new Room(5, "Room name");
			var resultRoom2 = new Room(3, "Room name");

			Assert.IsFalse(resultRoom1.Equals(resultRoom2));
		}

		[TestMethod]
		public void СompareRoomWithTheSameNumberNegative()
		{
			var resultRoom1 = new Room(3, "Room name");
			var resultRoom2 = new Room(3, "Room name");

			Assert.IsTrue(resultRoom1.Equals(resultRoom2));
		}
	}
}
