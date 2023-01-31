using University.Employee;

namespace UniversityUnitTests
{
	[TestClass]
	public class EmployeeUnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateTeacher_WithInvalidValueTaxId_Negative()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()),-2, new("coures name", "course description"));
		}

		[TestMethod]
		public void CreateTeacher_WithZeroValueTaxId_Positive()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 0, new("coures name", "course description"));
			Assert.AreEqual(0, resultEmployee.TaxId);
		}

		[TestMethod]
		public void CreateTeacher_WithValidValueTaxId_Positive()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 3636, new("coures name", "course description"));
			Assert.AreEqual(3636,resultEmployee.TaxId);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateSupportStaff_WithInvalidValueTaxId_Negative()
		{
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), -2, "name", "duties");
		}

		[TestMethod]
		public void CreateSupportStaff_WithZeroValueTaxId_Positive()
		{
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 0, "name", "duties");
			Assert.AreEqual(0, resultStaff.TaxId);
		}

		[TestMethod]
		public void CreateSupportStaff_WithValidValueTaxId_Positive()
		{
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties"); ;
			Assert.AreEqual(3333, resultStaff.TaxId);
		}

		[TestMethod]
		public void СompareEmployeeWithTheSameTaxIdNegative()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 3333, new("coures name", "course description"));
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties"); 
			
			Assert.IsTrue(resultEmployee.Equals(resultStaff));
			Assert.AreEqual(resultEmployee.GetHashCode(), resultStaff.GetHashCode());
		}

		[TestMethod]
		public void СompareEmployeeWithDifferentTaxIdPositive()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			Assert.IsFalse(resultEmployee.Equals(resultStaff));
			Assert.AreNotEqual(resultEmployee.GetHashCode(), resultStaff.GetHashCode());
		}

		[TestMethod]
		public void CompareLenghtNameLastNameEmployeePositive()
		{
			UniversityEmployee resultEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			UniversityEmployee resultStaff = new SupportStaff(new("Name", "LastNamee", new()), 3333, "name", "duties");

			Assert.AreEqual(1, resultEmployee.CompareTo(resultStaff));
		}

		[TestMethod]
		public void CompareLenghtNameLastNameEmployeeWithZeroValue()
		{
			UniversityEmployee resultEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			UniversityEmployee resultStaff = null;

			Assert.AreEqual(-1, resultEmployee.CompareTo(resultStaff));
		}
	}
}