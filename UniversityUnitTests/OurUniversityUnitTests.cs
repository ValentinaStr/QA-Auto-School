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
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			var university = new OurUniversity(new (new("", "",new("", "", 22, 22)),10), new() { }, new() { });
			university.AddEmployee(resultEmployee);
			university.AddEmployee(resultStaff);

			Assert.AreEqual(2,university.AllUniversityEmployees.Count);
		}

		[TestMethod]
		public void AddTheSameEmployeeNegative()
		{
			var resultEmployee = new Teacher(new("Name", "LastName", new()), 3, new("coures name", "course description"));
			var resultStaff = new SupportStaff(new("Name", "LastName", new()), 3333, "name", "duties");

			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() {resultEmployee, resultStaff }, new() { });
			
			university.AddEmployee(resultEmployee);
			university.AddEmployee(resultStaff);

			Assert.AreEqual(2, university.AllUniversityEmployees.Count);
		}

		[TestMethod]
		public void AddNewBuildingPositive()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			var resultBuilding2 = new Building(28, "Main", new(), new("London", "sreet", 235));

			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() { }, new() { });
			university.AddBuilding(resultBuilding1);
			university.AddBuilding(resultBuilding2);

			Assert.AreEqual(2, university.Allbuildings.Count);
		}

		[TestMethod]
		public void AddTheSameBuildingNegative()
		{
			var resultBuilding1 = new Building(23, "Main", new(), new("London", "sreet", 236));
			var university = new OurUniversity(new(new("", "", new("", "", 22, 22)), 10), new() {}, new() {resultBuilding1});

			university.AddBuilding(resultBuilding1);

			Assert.AreEqual(1, university.Allbuildings.Count);
		}
	}
}
