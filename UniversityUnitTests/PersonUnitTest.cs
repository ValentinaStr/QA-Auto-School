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
			Person resultAddress = new("abc", "dfj", null);

			Assert.AreEqual(resultAddress.Address.City, addressDefault.City);
			Assert.AreEqual(resultAddress.Address.Street, addressDefault.Street);
			Assert.AreEqual(resultAddress.Address.House, addressDefault.House);
			Assert.AreEqual(resultAddress.Address.Flat, addressDefault.Flat);
		}

		[TestMethod]
		public void SumNameLastNamePositive()
		{
			Person resultLenght = new("abc", "dfj", new());
			Assert.AreEqual(6, resultLenght.LenghtNameLastName);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NameIsNullNegative() 
		{
			Person resultName = new(null, "LastName", new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void LastNameIstNullNegative()
		{
			Person resultLastName = new("Name", null, new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void LenghtNameLastName_WithLongNameNegative() 
		{
			Person resultLenght = new("123456789_1234567890_1", "", new());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void LenghtNameLastName_WithLongLastNameNegative()
		{
			Person resultLenght = new("", "123456789_123456789_1", new());
		}
	}
}
