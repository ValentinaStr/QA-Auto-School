using Microsoft.VisualStudio.TestTools.UnitTesting;
using Building_Linq.RealProperty;
using University.Employee;

namespace UniversityUnitTests
{
	[TestClass]
	public class BuildingUnitTests
	{
		[TestMethod]
		public void СompareBuildingWithDifferentHouseNumberPositive()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 235));
			var resaltBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsFalse(resaltBuilding1.Equals(resaltBuilding2));
		}

		[TestMethod]
		public void СompareBuildingWithDifferentStreetPositive()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("London", "sreet1", 236));
			var resaltBuilding2 = new Building(23, "Main", new(), new("London", "sreet2", 236));

			Assert.IsFalse(resaltBuilding1.Equals(resaltBuilding2));
		}

		[TestMethod]
		public void СompareBuildingWithDifferentTownPositive()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("Minsk", "sreet", 236));
			var resaltBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsFalse(resaltBuilding1.Equals(resaltBuilding2));
		}

		[TestMethod]
		public void СompareBuildingWithTheSameAddressNegative()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			var resaltBuilding2 = new Building(23, "Main", new(), new("London", "sreet", 236));

			Assert.IsTrue(resaltBuilding1.Equals(resaltBuilding2));
		}

		[TestMethod]
		public void AddRoomWithTheSameNumberNegative()
		{
			Room resaltroom = new Room(3, "Room name");
			List<Room> listRooms = new() { resaltroom };
			var resaltBuilding = new Building(23, "Main", listRooms, new("London", "sreet", 236));
			
			Assert.IsFalse(resaltBuilding.AddRoom(resaltroom));
		}

		public void AddRoomPositive()
		{
			Room resaltroom = new Room(1, "Room name");
			List<Room> listRooms = new() {new (3, "Room name") , new(4,"Room name")};
			var resaltBuilding = new Building(23, "Main", listRooms, new("London", "sreet", 236));

			Assert.IsTrue(resaltBuilding.AddRoom(resaltroom));
		}
	}
}
