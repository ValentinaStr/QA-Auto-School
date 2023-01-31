using Microsoft.VisualStudio.TestTools.UnitTesting;
using Building_Linq.RealProperty;
using University.Employee;
using Building_Linq;

namespace UniversityUnitTests
{
	[TestClass]
	public class OurUniversityUnitTests
	{
		[TestMethod]
		public void AddNewEmployeePositive()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			var university = new OurUniversity(new (new("", "",new("", "", 22, 22)),10), new() { }, new() { });
			university.AddEmployee(resaltEmployee);
			university.AddEmployee(resaltStaff);

			Assert.AreEqual(2,university.AllUniversityEmployees.Count);
		}

		[TestMethod]
		public void AddTheSameEmployeeNegative()
		{
			var resaltEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resaltStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() {resaltEmployee, resaltStaff }, new() { });
			
			university.AddEmployee(resaltEmployee);
			university.AddEmployee(resaltStaff);

			Assert.AreEqual(2, university.AllUniversityEmployees.Count);
		}

		[TestMethod]
		public void AddNewBuildingPositive()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			var resaltBuilding2 = new Building(28, "Main", new(), new("London", "sreet", 235));

			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() { }, new() { });
			university.AddBuilding(resaltBuilding1);
			university.AddBuilding(resaltBuilding2);

			Assert.AreEqual(2, university.Allbuildings.Count);
		}

		[TestMethod]
		public void AddTheSameBuildingNegative()
		{
			var resaltBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			
			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() {}, new() {resaltBuilding1});

			university.AddBuilding(resaltBuilding1);

			Assert.AreEqual(1, university.Allbuildings.Count);
		}
	}
}
