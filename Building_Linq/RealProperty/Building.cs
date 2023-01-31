namespace Building_LINQ.RealProperty
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
            if (obj == null || obj.GetType() != typeof(Building)) return false;
            var building = (Building)obj;
            return building.AddressBulding.City.Equals(AddressBulding.City)
                && building.AddressBulding.Street.Equals(AddressBulding.Street)
                && building.AddressBulding.HouseNumber.Equals(AddressBulding.HouseNumber);
        }

		public override int GetHashCode()
		{
			return AddressBulding.City.GetHashCode() 
                + AddressBulding.Street.GetHashCode() 
                + AddressBulding.HouseNumber.GetHashCode();
		}

		public bool AddRoom(Room roomToAdd)
        {
            if (Rooms.Contains(roomToAdd))
            {
                return false;
            }
            Rooms.Add(roomToAdd);
            return true;
        }
    }
}
