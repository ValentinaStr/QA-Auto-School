
namespace DataTypesIntro
{
	internal class Address
	{
		public string City;
		public string Street;
		public int House;
		public int Flat;

		public Address(string town, string street, int house, int flat)
			{
				City = town;
				this.Street = street;
				this.House = house;
				this.Flat = flat;
			}
		}
}
