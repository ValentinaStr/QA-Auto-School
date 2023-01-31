using University.Candidates;

namespace UniversityUnitTests
{
	[TestClass]
	public  class PersonUnitTest
	{
		[TestMethod]
		public void CreatePersonWithEmptyAddressPositive()
		{
			Address addressDefault = new();
			Person resaltAddress = new("abc", "dfj", null);

			Assert.AreEqual(resaltAddress.Address.City, addressDefault.City);
			Assert.AreEqual(resaltAddress.Address.Street, addressDefault.Street);
			Assert.AreEqual(resaltAddress.Address.House, addressDefault.House);
			Assert.AreEqual(resaltAddress.Address.Flat, addressDefault.Flat);
		}

		[TestMethod]
		public void SumNameLastNamePositive()
		{
			Person resaltLenght = new("abc", "dfj", new());
			Assert.AreEqual(6, resaltLenght.LenghtNameLastName);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NameIsNullNegative() 
		{
			Person resaltName = new(null, "LastName", new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void LastNameIstNullNegative()
		{
			Person resaltLastName = new("Name", null, new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void LenghtNameLastName_WithLongNameNegative() 
		{
			Person resaltLenght = new("123456789_1234567890_1", "", new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void LenghtNameLastName_WithLongLastNameNegative()
		{
			Person resaltLenght = new("", "123456789_123456789_1", new());
		}
	}
}
