using University.Candidates;
using University.Employee;

namespace University
{
	public class Program
	{
		static void Main(string[] args)
		{
			Candidate candidateFirst = new(
				new Person("Harry", "Potter",
					new Address("Bracknell", "Picket Post Close", 12, 1)),
				new SubjectScore[] {
					new SubjectScore("Astronomy", 50),
					new SubjectScore("Potions", 30),
					new SubjectScore("Transfiguration", 60),
					new SubjectScore("Flying", 25),
					new SubjectScore("Music", 20)
					}
			);
			Candidate candidateSecond = new(
				new Person("Ronald", "Weasley",
					new Address("Ottery St Catchpole", "The Burrow", 1, 1)),
				new SubjectScore[] {
					new SubjectScore("Astronomy", 10),
					new SubjectScore("Potions", 30),
					new SubjectScore("Transfiguration", 60),
					new SubjectScore("Flying", 75),
					new SubjectScore("Music", 80)
					}
			);
			Candidate candidateThird = new(
				new Person("Draco", "Malfoy",
					new Address("Wiltshire", "Malfoy Manor", 1, 3)),
				new SubjectScore[]{
					new SubjectScore("Astronomy", 10),
					new SubjectScore("Potions", 30),
					new SubjectScore("Transfiguration", 60),
					new SubjectScore("Charms", 80)
					}
			);
			Candidate candidateFourth = new(
				new Person("Hermione", "Granger",
					new Address("Hampstead", "Hampstead Heath", 2, 3)),
				new SubjectScore[]{
					new SubjectScore("Astronomy", 90),
					new SubjectScore("Potions", 70),
					new SubjectScore("Transfiguration", 95),
					new SubjectScore("Flying", 85),
					new SubjectScore("Charms", 87)
					}
			);
			Candidate candidateFifth = new(
				new Person("Ginevra", "Weasley",
					new Address("Ottery St Catchpole", "The Burrow", 1, 2)),
				new SubjectScore[]{
					new SubjectScore("Astronomy", 70),
					new SubjectScore("Potions", 60),
					new SubjectScore("Transfiguration", 75),
					new SubjectScore("Flying", 85),
					new SubjectScore("Charms", 87)
				}
			);

			Candidate[] allCandidates = new Candidate[]{
				candidateFirst,
				candidateSecond,
				candidateThird,
				candidateFourth,
				candidateFifth
				};

			foreach (Candidate candidate in allCandidates)
			{
				Console.WriteLine(candidate.GetStreet());
			}

			string subjectName = "Astronomy";
			int maxScoreSubject = SubjectScore.MinScore;
			string? candidateLastnameMaxScore = null;
			foreach (Candidate candidate in allCandidates)
			{
				int score = candidate.GetScoreSubject(subjectName);
				if (score > maxScoreSubject)
				{
					maxScoreSubject = score;
					candidateLastnameMaxScore = candidate.Person.LastName;
				}
			}
			Console.WriteLine($"Max score of {subjectName} {maxScoreSubject} {candidateLastnameMaxScore}");

			UniversityEmployee deanOfSlytherin = new Teacher(
				new Person("Severus", "Snape",
					new Address("London", "St. Aldates", 24, 1)),
				124456789,
				new Course("Defence against the Dark Arts", "A compulsory subject from the first year of study to the fifth"));

			UniversityEmployee deanOfGryffindor = new DegreeTeacher(
				new Person("Minerva", "McGonagall",
					new Address("London", "St. Aldates", 23, 1)),
				114567891,
				new Course("Transfiguration", "Studies magical ways to transform one object into another"),
				"Doctor of Transfiguration",
				"Professor");

			UniversityEmployee deanHufflepuff = new DegreeTeacher(
				new Person("Pomona", "Sprout",
					new Address("London", "St. Aldates", 26, 1)),
				122456789,
				new Course("Herbology", "Study of various plants"),
				"Doktor of Herbology",
				"Professor");

			UniversityEmployee deanRavenclaw = new DegreeTeacher(
				new Person("Filius", "Flitwick",
					new Address("London", "St. Aldates", 25, 1)),
				102569877,
				new Course("Charms", "Learns various movements with a stick, while saying one or more words at the same time "),
				"Doctor of Charms",
				"Professor");
			
			UniversityEmployee employee3 = new SupportStaff(
				new Person("Bloody", "Baron",
					new Address("Oxford", "St. Aldates", 24, 65)),
				1234,
				"Ghost",
				"Ghost of Slytherin");
						
			UniversityEmployee employee5 = new SupportStaff(
			   new Person("Nicholas", "Porpington",
					new Address("Oxford", "St. Aldates", 23, 66)),
			   654789,
			   "Ghost",
			   "Ghost of Gryffindor");

			UniversityEmployee[] allUniversityEmployees = {deanOfSlytherin, deanOfGryffindor, employee3, deanHufflepuff, employee5, deanRavenclaw };

			foreach (UniversityEmployee employee in allUniversityEmployees)
			{
				Console.WriteLine(employee.GetOfficialDuties());
			}

			Console.WriteLine("");

			foreach (UniversityEmployee employee in allUniversityEmployees)
			{
				if (employee is Teacher)
				{
					Console.WriteLine(employee.GetOfficialDuties());
				}
			}
		}
	}
}

