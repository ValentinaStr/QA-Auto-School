namespace Task_3
{
	public class AddressBulding
	{
		private int _house;
		public string City { get; set; }
		public string Street { get; set; }
		public int HouseNumber
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
		public AddressBulding(string town, string street, int houseNumber)
		{
			City = town;
			Street = street;
			HouseNumber = houseNumber;
		}

	}
		
}
