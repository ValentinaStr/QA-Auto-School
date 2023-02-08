using Building_Linq.RealProperty;

namespace UniversityUnitTests
{
	[TestClass]
	public class AddressBuildingUnitTests
	{
		[TestMethod]
		public void Addreess_WithValidBuildingNumberPositive()
		{
			AddressBulding address1 = new("City", "Street", 1);
			Assert.AreEqual(1, address1.HouseNumber, "Bulding number with min value");

			AddressBulding address9_999 = new("City", "Street", 9999);
			Assert.AreEqual(9999, address9_999.HouseNumber, "Bulding number with max value");

			AddressBulding address555 = new("City", "Street", 555);
			Assert.AreEqual(555, address555.HouseNumber, "Bulding number with valid value");
		}

		[TestMethod]
		public void Addrees_WithInvalidBuildingNumberNegative()
		{
			AddressBulding addressWithNegativeHouseValue = new("City", "Street", -1);
			Assert.AreEqual(0, addressWithNegativeHouseValue.HouseNumber, "Bulding number has a negative value");

			AddressBulding addressWithZeroHouseValue = new("City", "Street", 0);
			Assert.AreEqual(0, addressWithZeroHouseValue.HouseNumber, "Bulding number is zero");

			AddressBulding addressWithGreaterHouseValue = new("City", "Street", 10_0000);
			Assert.AreEqual(0, addressWithGreaterHouseValue.HouseNumber, "Bulding number has a value greater than the maximum");
		}

	}
}
