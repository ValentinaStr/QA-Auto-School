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
			var resaltEmployee = new Teacher(new("Name", "LastName", new()),-2, new("coures name", "course description"));
		}

		[TestMethod]
		public void CreateTeacher_WithZeroValueTaxId_Positive()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 0, new("coures name", "course description"));
		}

		[TestMethod]
		public void CreateTeacher_WithValidValueTaxId_Positive()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 3636, new("coures name", "course description"));
			Assert.AreEqual(3636,resaltEmployee.TaxId);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateSupportStaff_WithInvalidValueTaxId_Negative()
		{
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), -2, "name", "duties");
		}

		[TestMethod]
		public void CreateSupportStaff_WithZeroValueTaxId_Positive()
		{
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 0, "name", "duties");
			Assert.AreEqual(0, resaltStaff.TaxId);
		}

		[TestMethod]
		public void CreateSupportStaff_WithValidValueTaxId_Positive()
		{
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties"); ;
			Assert.AreEqual(3333, resaltStaff.TaxId);
		}

		[TestMethod]
		public void СompareEmployeeWithTheSameTaxIdNegative()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 3333, new("coures name", "course description"));
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties"); 
			
			Assert.IsTrue(resaltEmployee.Equals(resaltStaff));
		}

		[TestMethod]
		public void СompareEmployeeWithDifferentTaxIdPositive()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			Assert.IsFalse(resaltEmployee.Equals(resaltStaff));
		}

		[TestMethod]
		public void CompareLenghtNameLastNameEmployeePositive()
		{
			UniversityEmployee resaltEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			UniversityEmployee resaltStaff = new SupportStaff(new("Name", "LastNamee", new()), 3333, "name", "duties");

			Assert.AreEqual(1, resaltEmployee.CompareTo(resaltStaff));
		}

		[TestMethod]
		public void CompareLenghtNameLastNameEmployeeWithZeroValue()
		{
			UniversityEmployee resaltEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			UniversityEmployee resaltStaff = null;

			Assert.AreEqual(-1, resaltEmployee.CompareTo(resaltStaff));
		}
	}
}