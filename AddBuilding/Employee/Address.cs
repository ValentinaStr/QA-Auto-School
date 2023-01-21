namespace AddBuilding
{ 
	public class Address
    {
        private int _house;
        private int _flat;
        public string City { get; set; }
        public string Street { get; set; }
        public int House
        {
            get => _house;
            set
            {
                if (value > 0 && value < 10_000)
                {
                    _house = value;
                }
            }
        }
        public int Flat
        {
            get => _flat;
            set
            {
                if (value > 0 && value < 1_000)
                {
                    _flat = value;
                }
            }

        }

        public Address(string town, string street, int house, int flat)
        {
            City = town;
            Street = street;
            House = house;
            Flat = flat;
        }
    }
}
