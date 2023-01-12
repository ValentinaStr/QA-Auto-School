namespace Task_3
{
	public class Building
	{
		public int Number { get; set; }
		public string Name { get; set; }
		public List<Room> Rooms { get; set; }
		public AddressBulding AddressBulding { get; set; }

		public Building(int number, string name, List<Room> rooms, AddressBulding addressBulding)
		{
			Number = number;
			Name = name;
			Rooms = rooms;
			AddressBulding = addressBulding;
		}
	}
}
