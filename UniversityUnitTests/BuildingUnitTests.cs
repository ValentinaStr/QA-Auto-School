using Building_Linq.RealProperty;

namespace UniversityUnitTests
{
	[TestClass]
	public class BuildingUnitTests
	{
		[TestMethod]
		public void СompareBuildingWithDifferentHouseNumberPositive()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 235));
			var resultBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsFalse(resultBuilding1.Equals(resultBuilding2));
			Assert.AreNotEqual(resultBuilding1.GetHashCode(), resultBuilding2.GetHashCode());
		}

		[TestMethod]
		public void СompareBuildingWithDifferentStreetPositive()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("London", "sreet1", 236));
			var resultBuilding2 = new Building(23, "Main", new(), new("London", "sreet2", 236));

			Assert.IsFalse(resultBuilding1.Equals(resultBuilding2));
			Assert.AreNotEqual(resultBuilding1.GetHashCode(), resultBuilding2.GetHashCode());
		}

		[TestMethod]
		public void СompareBuildingWithDifferentTownPositive()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("Minsk", "sreet", 236));
			var resultBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsFalse(resultBuilding1.Equals(resultBuilding2));
			Assert.AreNotEqual(resultBuilding1.GetHashCode(), resultBuilding2.GetHashCode());
		}

		[TestMethod]
		public void СompareBuildingWithTheSameAddressNegative()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			var resultBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsTrue(resultBuilding1.Equals(resultBuilding2));
			Assert.AreEqual(resultBuilding1.GetHashCode(),resultBuilding2.GetHashCode());
		}

		[TestMethod]
		public void AddRoomWithTheSameNumberNegative()
		{
			Room resultroom = new Room(3, "Room name");
			List<Room> listRooms = new() { resultroom };
			var resultBuilding = new Building(23, "Main", listRooms, new("London", "sreet", 236));
			
			Assert.IsFalse(resultBuilding.AddRoom(resultroom));
		}

		public void AddRoomPositive()
		{
			Room resultroom = new Room(1, "Room name");
			List<Room> listRooms = new() {new (3, "Room name") , new(4,"Room name")};
			var resultBuilding = new Building(23, "Main", listRooms, new("London", "sreet", 236));

			Assert.IsTrue(resultBuilding.AddRoom(resultroom));
		}
	}
}
