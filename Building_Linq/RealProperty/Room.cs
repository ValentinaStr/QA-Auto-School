namespace Building_Linq.RealProperty
{
    public class Room
    {
        public int NumberRoom { get; set; }
        public string Name { get; set; }

        public Room(int numder, string name)
        {
            NumberRoom = numder;
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return obj is Room room && room != null && room.NumberRoom == NumberRoom;
        }
		public override int GetHashCode()
		{
			return NumberRoom.GetHashCode();
		}
	}
}
