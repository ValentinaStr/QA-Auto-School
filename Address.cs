
namespace DataTypesIntro
{
	public class Address
	{
		private int _House;
		private int _Flat;
		public string City { get; set; }
		public string Street { get; set; }
		public int House
		{
			get => _House; 
			set
			{
				if (value > 0 && value < 10_000)
				{
					_House = value;
				}
			}
		}
		public int Flat
		{
			get => _Flat;

		    set
			{
				if(value > 0 && value < 1_000)
				{
					_Flat = value;
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
