using Building_Linq.RealProperty;
using Building_Linq;
using University.Candidates;
using University.Employee;

namespace Building_Linq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var theMainBuilding = new Building(
				1,
				"Main building",
				new () { 
					new (1, "Rector's office"),
					new (2, "Admissions team"),
					new (3, "Library"),
					new (4, "Great Hall")
					},
				new ("Oxford", "St. Aldates", 22)
				);

			var gryffindorTower = new Building(
				2,
				"Gryffindor Tower",
				new () {
					new (2, "Library"),
					new (3, "Common Room"),
					new (4, "Girls' bedroom"),
					new (5, "Boys' bedroom")
					},
				new ("Oxford", "St. Aldates", 23)
				);

			var slytherinTower = new Building(
				3,
				"Slytherin dungeons",
				new () {
					new (2, "Library"),
					new (3, "Common Room"),
					new (4, "Girls' bedroom"),
					new (5, "Boys' bedroom")
					},
				new ("Oxford", "St. Aldates", 24)
				);

			var ravenclawTower = new Building(
				4,
				"Ravenclaw Tower",
				new () {
					new (2, "Library"),
					new (3, "Common Room"),
					new (4, "Girls' bedroom"),
					new (5, "Boys' bedroom")
					},
				new ("Oxford", "St. Aldates", 25)
				);

			var hufflepuffTower = new Building(
				5,
				"Hufflepuff barrel",
				new () {
					new (2, "Library"),
					new (3, "Common Room"),
					new (4, "Girls' bedroom"),
					new (5, "Boys' bedroom")
					},
				new ("Oxford", "St. Aldates", 26)
				);

			var allBuilding = new List<Building>() {theMainBuilding };

			var deanOfSlytherin = new Teacher(
				new ("Severus", "Snape",
					new ("London", "St. Aldates", 24, 1)),
				124456789,
				new ("Defence against the Dark Arts", "A compulsory subject from the first year of study to the fifth"));

			var deanOfGryffindor = new DegreeTeacher(
				new ("Minerva", "McGonagall",
					new ("London", "St. Aldates", 23, 1)),
				114567891,
				new ("Transfiguration", "Studies magical ways to transform one object into another"),
				"Doctor of Transfiguration",
				"Professor");

			var deanHufflepuff = new DegreeTeacher(new ("Pomona", "Sprout", new ("London", "St. Aldates", 26, 1)),
				122456789,
				new ("Herbology", "Study of various plants"),
				"Doktor of Herbology",
				"Professor");

			var deanRavenclaw = new DegreeTeacher(new ("Filius", "Flitwick", new ("London", "St. Aldates", 25, 1)),
				102569877,
				new ("Charms", "Learns various movements with a stick, while saying one or more words at the same time "),
				"Doctor of Charms",
				"Professor");

			var allUniversityEmployees = new List<UniversityEmployee>() { deanOfSlytherin };

			var rector = new Rector (new("Albus", "Dumbledore", new ("Oxford", "St. Aldates", 22, 22)),
				10000001);

			var hogwarts = new OurUniversity(rector,
				allUniversityEmployees,
				allBuilding);

			hogwarts.AddEmployee(deanOfGryffindor);
			hogwarts.AddEmployee(deanHufflepuff);
			hogwarts.AddEmployee(deanRavenclaw);

			hogwarts.AddBuilding(slytherinTower);
			hogwarts.AddBuilding(gryffindorTower);
			hogwarts.AddBuilding(slytherinTower);
			hogwarts.AddBuilding(ravenclawTower);
			hogwarts.AddBuilding(hufflepuffTower);
			hogwarts.AddBuilding(slytherinTower);

			// Task_5.1 A list employees whose last names begin with the given letter.

			var letterForSelected = 'S';
			var selectedByBeginLastnameEmployees = hogwarts.AllUniversityEmployees
				.Where(p => p.EmployeePerson.LastName.StartsWith(letterForSelected))
				.OrderBy(p => p.TaxId)
				.ToList();

			Console.WriteLine("Task 5.1");
			Console.WriteLine($"  List of employees with last name starting {letterForSelected}:");

			foreach (var employee in selectedByBeginLastnameEmployees)
			{
				Console.WriteLine(employee.GetOfficialDuties());
			}

			// Task_5.2 List of employees leading a particular course.

			var courseForSelected = "Herbology";
			var selectedByCourseEmployees = hogwarts.AllUniversityEmployees.OfType<Teacher>()
				.Where(p => p.CourseName.Name.Equals(courseForSelected))
				.ToList();

			Console.WriteLine("Task 5.2");
			Console.WriteLine($"  List of employees who reading course {courseForSelected}:");

			foreach (var employee in selectedByCourseEmployees)
			{
				Console.WriteLine(employee.GetOfficialDuties());
			}

			//Task_5.3 Display TaxID and job responsibilities of each employee.

			var listOfTaxIDDuties = hogwarts.AllUniversityEmployees.Select(p => (p.TaxId, p.GetOfficialDuties())).ToList();

			Console.WriteLine("Task 5.3");
			Console.WriteLine("  TaxId and responsibilities of each employee ");
			foreach (var item in listOfTaxIDDuties)
			{
				Console.WriteLine(item);
			}

			//Task_5.4 Display the addresses of all buildings that have a room with a cer-tain number.

			var roomNumberForSelect = 2;
			var listBuildingAddress = hogwarts.Allbuildings
				.Where(x => x.Rooms.Any(x => x.NumberRoom == roomNumberForSelect))
				.Select(x => (x.AddressBulding.City, x.AddressBulding.Street, x.AddressBulding.HouseNumber))
				.ToList();

			Console.WriteLine("Task 5.4");
			Console.WriteLine($"  List of buiding that have a room with number: {roomNumberForSelect}");

			foreach (var item in listBuildingAddress)
			{
				Console.WriteLine("City: {0}, Street: {1}, Building number: {2}", item.City, item.Street, item.HouseNumber);
			}

			//Task_5.5 Display the address of the building with the maximum number of rooms in it

			var buildingWithMostRooms = hogwarts.Allbuildings.MaxBy(x => x.Rooms.Count());

			Console.WriteLine("Task 5.5");
			Console.WriteLine($"  The building with most Rooms address is :" +
				$"{buildingWithMostRooms.AddressBulding.City}," +
				$"{buildingWithMostRooms.AddressBulding.Street}," +
				$"{buildingWithMostRooms.AddressBulding.HouseNumber}");

			UniversityEmployee teacherGryffindor = new DegreeTeacher(new Person("Alastor", "Moody", new Address("London", "St. Aldates", 22, 10)),
				114557333,
				new Course("Defence against the Dark Arts", "A compulsory subject from the first year of study to the fifth"),
				"Doctor of DADA",
				"Professor");

			hogwarts.AddEmployee(teacherGryffindor);

			// Task_5.6 Display the most common employee last name and the number of such employees

			var lastNameMost = hogwarts.AllUniversityEmployees.GroupBy(x => x.EmployeePerson.LastName).MaxBy(x => x.Count());

			Console.WriteLine("Task 5.6");
			Console.WriteLine($"  The most popular LastName is {lastNameMost?.Key} in quantity {lastNameMost?.Count()}");

			try
			{
				new Teacher(new Person("Lucius", "Malfoy", new Address("Oxford", "Diagon Alley", 23, 22)),
					-123654,
					new Course("Death Eaters", "the seizure of power by purebred magicians,"));
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}

			try
			{
				new Person("Fleur Isabelle", "Delacour", new Address("Oxford", "Diagon Alley", 25, 28)); ;
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}

			var sortedByLinghtLastnameEmployees = hogwarts.AllUniversityEmployees.
				OrderByDescending(p => (p.EmployeePerson.LastName.Length + p.EmployeePerson.Name.Length)).ToList();
			
			hogwarts.AllUniversityEmployees.Sort();

			hogwarts.AllUniversityEmployees.Sort((x, y) => (y.EmployeePerson.Name.Length + y.EmployeePerson.LastName.Length)
				.CompareTo((x.EmployeePerson.Name.Length + x.EmployeePerson.LastName.Length)));

			IComparer<UniversityEmployee> comparer = new MyOrderingEmployee();
			hogwarts.AllUniversityEmployees.Sort(comparer);

			Console.WriteLine("THE END");
		}
	}
}