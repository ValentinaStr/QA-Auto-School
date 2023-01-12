namespace Task_3
{
	internal class Building
	{
		public int Number { get; set; }
		public string Name { get; set; }
		public Room[] Rooms { get; set; }
		public AddressBulding AddressBulding { get; set; }

		public Building(int number, string name, Room[] rooms, AddressBulding addressBulding)
		{
			Number = number;
			Name = name;
			Rooms = rooms;
			AddressBulding = addressBulding;
		}
	}
}
