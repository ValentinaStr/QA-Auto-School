namespace AddBuilding
{
	public class Building
	{
		public int NumberBuilding { get; set; }
		public string Name { get; set; }
		public List<Room> Rooms { get; set; }
		public AddressBulding AddressBulding { get; set; }

		public Building(int number, string name, List<Room> rooms, AddressBulding addressBulding)
		{
			NumberBuilding = number;
			Name = name;
			Rooms = rooms;
			AddressBulding = addressBulding;
		}

		public override bool Equals(object? obj)
		{
			Building? building = obj as Building;
			if (building != null)
			{
				return building.AddressBulding.City.Equals(AddressBulding.City) &&
					building.AddressBulding.Street.Equals(AddressBulding.Street) &&
					building.AddressBulding.HouseNumber.Equals(AddressBulding.HouseNumber);
				return false;
			}
			return true;
		}

		public bool AddRoom(Room roomToAdd)
		{
			foreach (var room in Rooms)
			{
				if (roomToAdd.Equals(room))
				{
					return false;
				}
			}
			Rooms.Add(roomToAdd);
			return true;
		}

	}
}
