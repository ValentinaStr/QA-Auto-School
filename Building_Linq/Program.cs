using Building_LINQ.RealProperty;
using Building_LINQ;
using University.Candidates;
using University.Employee;

namespace Building_Linq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Building theMainBuilding = new(1,
				"Main building",
				new List<Room>() { new Room(1, "Rector's office"), new Room(2, "Admissions team"), new Room(3, "Library"), new Room(4, "Great Hall") },
				new AddressBulding("Oxford", "St. Aldates", 22)
				);

			Building gryffindorTower = new(2,
				"Gryffindor Tower",
				new List<Room>() { new Room(2, "Library"), new Room(3, "Common Room"), new Room(4, "Girls' bedroom"), new Room(5, "Boys' bedroom") },
				new AddressBulding("Oxford", "St. Aldates", 23)
				);

			Building slytherinTower = new(3,
				"Slytherin dungeons",
				new List<Room>() { new Room(2, "Library"), new Room(3, "Common Room"), new Room(4, "Girls' bedroom"), new Room(5, "Boys' bedroom") },
				new AddressBulding("Oxford", "St. Aldates", 24)
				);

			Building ravenclawTower = new(4,
				"Ravenclaw Tower",
				new List<Room>() { new Room(2, "Library"), new Room(3, "Common Room"), new Room(4, "Girls' bedroom"), new Room(5, "Boys' bedroom") },
				new AddressBulding("Oxford", "St. Aldates", 25)
				);

			Building hufflepuffTower = new(5,
				"Hufflepuff barrel",
				new List<Room>() { new Room(2, "Library"), new Room(3, "Common Room"), new Room(4, "Girls' bedroom"), new Room(5, "Boys' bedroom") },
				new AddressBulding("Oxford", "St. Aldates", 26)
				);

			List<Building> allBuilding = new() { theMainBuilding };

			UniversityEmployee deanOfSlytherin = new Teacher(new Person("Severus", "Snape",
				new Address("London", "St. Aldates", 24, 1)),
				124456789,
				new Course("Defence against the Dark Arts", "A compulsory subject from the first year of study to the fifth"));

			UniversityEmployee deanOfGryffindor = new DegreeTeacher(new Person("Minerva", "McGonagall", new Address("London", "St. Aldates", 23, 1)),
				114567891,
				new Course("Transfiguration", "Studies magical ways to transform one object into another"),
				"Doctor of Transfiguration",
				"Professor");

			UniversityEmployee deanHufflepuff = new DegreeTeacher(new Person("Pomona", "Sprout", new Address("London", "St. Aldates", 26, 1)),
				122456789,
				new Course("Herbology", "Study of various plants"),
				"Doktor of Herbology",
				"Professor");

			UniversityEmployee deanRavenclaw = new DegreeTeacher(new Person("Filius", "Flitwick", new Address("London", "St. Aldates", 25, 1)),
				102569877,
				new Course("Charms", "Learns various movements with a stick, while saying one or more words at the same time "),
				"Doctor of Charms",
				"Professor");

			List<UniversityEmployee> allUniversityEmployees = new() { deanOfSlytherin };

			Rector rector = new Rector(new Person("Albus", "Dumbledore", new Address("Oxford", "St. Aldates", 22, 22)),
				10000001);

			OurUniversity hogwarts = new(rector,
				allUniversityEmployees,
				allBuilding);

		hogwarts.AddEmployee(deanRavenclaw);
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

			UniversityEmployee teacherGryffindor = new DegreeTeacher(new Person("Alastor", "«Mad-Eye» Moody", new Address("London", "St. Aldates", 22, 10)),
				114557333,
				new Course("Defence against the Dark Arts", "A compulsory subject from the first year of study to the fifth"),
				"Doctor of DADA",
				"Professor");

			hogwarts.AddEmployee(teacherGryffindor);

			// Task_5.6 Display the most common employee last name and the number of such employees

			var lastNameMost = hogwarts.AllUniversityEmployees.GroupBy(x => x.EmployeePerson.LastName).MaxBy(x => x.Count());

			Console.WriteLine("Task 5.6");
			Console.WriteLine($"  The most popular LastName is {lastNameMost?.Key} in quantity {lastNameMost?.Count()}");
		}
	}
}