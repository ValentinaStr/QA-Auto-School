namespace AddBuilding
{
	public class Room
	{
		public  int NumberRoom { get; set; }
		public string Name { get; set; }

		public Room(int numder, string name)
		{
			NumberRoom = numder;
			Name = name;
		}
		public override bool Equals(object? obj)
		{
			Room? room = obj as Room;
			if (room != null)
			{
				return room.NumberRoom == NumberRoom;
			}
			return false;
		}
	}
}
