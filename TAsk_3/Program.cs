using Task_3;

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

		List<Building> allBuilding = new() { theMainBuilding, gryffindorTower, slytherinTower };

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

			List <UniversityEmployee> allUniversityEmployees = new () {deanOfSlytherin, deanOfGryffindor, deanHufflepuff};

		University hogwarts = new (new Person("Albus", "Dumbledore", new Address("Oxford", "St. Aldates", 22, 22)),
			allUniversityEmployees, allBuilding);
		
		hogwarts.AddEmployee(deanHufflepuff);
		hogwarts.AddBuilding(hufflepuffTower);
				
	}
}
