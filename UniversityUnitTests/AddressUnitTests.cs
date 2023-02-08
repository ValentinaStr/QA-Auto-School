using University.Candidates;

namespace UniversityUnitTests
{
	[TestClass]
	public class AddressUnitTests
	{
		[TestMethod]
		public void CreateAdress_WithDefaultValue()
		{
			Address addressWithDefaultValue = new Address();

			Assert.AreEqual("", addressWithDefaultValue.City, "Wrong Adress.City by default");
			Assert.AreEqual("", addressWithDefaultValue.Street, "Wrong Adress.Street by default");
			Assert.AreEqual(0, addressWithDefaultValue.House, "Wrong Adress.House by default");
			Assert.AreEqual(0, addressWithDefaultValue.Flat, "Wrong Adress.Flat by default");
		}

		[TestMethod]
		public void AddreessWithValidHouseNumberPositive()
		{
			Address address1 = new("City","Street",1,1);
			Assert.AreEqual(1, address1.House, "House number with min value");

			Address address9_999 = new("City", "Street", 9999, 1);
			Assert.AreEqual(9999, address9_999.House, "House number with max value");

			Address address555 = new("City", "Street", 555, 5);
			Assert.AreEqual(555, address555.House, "House number with valid value");
		}
		
		[TestMethod]
		public void AddreedsWithInvalidHouseNumberNegative()
		{
			Address addressWithNegativeHouseValue = new("City","Street", -1,2);
			Assert.AreEqual(0, addressWithNegativeHouseValue.House, "House number has a negative value");

			Address addressWithZeroHouseValue = new("City", "Street", 0, 2);
			Assert.AreEqual(0, addressWithZeroHouseValue.House, "House number is zero");

			Address addressWithGreaterHouseValue = new("City", "Street", 10_0000, 2);			
			Assert.AreEqual(0, addressWithGreaterHouseValue.House, "House number has a value greater than the maximum");			
		}

		[TestMethod]
		public void AddreessWithValidFlatNumberPositive()
		{
			Address address1 = new("City", "Street", 1, 1);
			Assert.AreEqual(1, address1.Flat, "Flat number whis min value");

			Address address999 = new("City", "Street", 2, 999);
			Assert.AreEqual(999, address999.Flat, "Flat number with max value");

			Address address555 = new("City", "Street", 5, 555);
			Assert.AreEqual(555, address555.Flat, "Flat number with valid value");
		}
		[TestMethod]
		public void AddreessWithInvalidFlatNumberNegative()
		{
			Address address2 = new("City", "Street", 2, -1);
			Assert.AreEqual(0, address2.Flat, "Flat number whis negative value");

			Address address0 = new("City", "Street", 2, 0);
			Assert.AreEqual(0, address0.Flat, "Flat number is zero");

			Address address1000 = new("City", "Street", 2, 1000);
			Assert.AreEqual(0, address1000.Flat, "Flat number with value greater than the maximum");
		}
	}
}
