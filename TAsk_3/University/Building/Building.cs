﻿namespace Task_3
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
				return building.NumberBuilding == NumberBuilding;
			}
			return false;
		}

		public bool AddRoom(Room roomToAdd)
		{
			foreach (var building in Rooms)
			{
				if (roomToAdd.Equals(building))
				{
					return false;
				}
			}
			Allbuildings.Add(roomToAdd);
			return true;
		}

	}
}