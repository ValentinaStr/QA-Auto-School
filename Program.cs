// See https://aka.ms/new-console-template for more information;
using System.IO;

namespace ArraysNew
{
    internal class Candidate
    {
        public Person person;
        public SubjectScores[] subjectScore;

        public Candidate(Person person, SubjectScores[] subjectScore)
        {
            this.person = person;
            this.subjectScore = subjectScore;
        }
    }
    internal class Person
    {
        public string name;
        public string surname;
        public Address address;

        public Person(string name, string surname, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
        }
    }
    internal class Address
    {
        public string town;
        public string street;
        public int house;
        public int flat;

        public Address(string town, string street, int house, int flat)
        {
            this.town = town;
            this.street = street;
            this.house = house;
            this.flat = flat;
        }
    }
    internal class SubjectScores
    {
        public string subject;
        public int score;

        public SubjectScores(string subject, int score)
        {
            this.subject = subject;
            this.score = score;
        }
    }


    internal class Program
    {
        private static void Main(string[] args)
        {
            
            SubjectScores[] certificateOne = {new SubjectScores("Maths", 50), new SubjectScores("Physics", 30),
            new SubjectScores("Foreign language", 60), new SubjectScores("Literature", 25), new SubjectScores("Music", 20)};
            Person personeFirst = new Person("William", "Jordan", new Address("London", "Carnaby Street", 25, 30));


            Candidate candidateFirst = new Candidate(personeFirst, certificateOne);

            SubjectScores[] certificateSecond = {new SubjectScores("Maths", 10),
            new SubjectScores("Physics", 30),
            new SubjectScores("Foreign language", 60),
            new SubjectScores("Literature", 75),
            new SubjectScores("Music", 80)};

            Candidate candidateSecond = new Candidate(new Person("Liam", "Peters",
                                                                 new Address("London", "Shaftesbury Avenue", 10, 13)),
                                                                 certificateSecond);

            Candidate candidatethird = new Candidate(new Person("Maksim", "Ivanov",
                new Address("Minsk", "Zybickaja", 20, 3)),
                new SubjectScores[5]{new SubjectScores("Maths", 10),
            new SubjectScores("Physics", 30),
            new SubjectScores("Foreign language", 60),
            new SubjectScores("Literature", 75),
            new SubjectScores("Music", 80)});

            Candidate candidatefourth = new Candidate(new Person("Victoria", "Zakharova",
                 new Address("Beijing", "Chang`an", 123, 357)),
                 new SubjectScores[5]{new SubjectScores("Maths", 9),
            new SubjectScores("Physics", 70),
            new SubjectScores("Foreign language", 95),
            new SubjectScores("Literature", 85),
            new SubjectScores("Music", 87)});

            Candidate candidatefifth = new Candidate(new Person("Anna", "Stone",
                 new Address("Minsk", "Pervomaiskaya", 23, 35)),
                 new SubjectScores[5]{new SubjectScores("Maths", 70),
            new SubjectScores("Physics", 60),
            new SubjectScores("Foreign language", 75),
            new SubjectScores("Literature", 85),
            new SubjectScores("Music", 87)});

           
            Candidate [] Allcandidates = new Candidate[]{candidateFirst, candidateSecond,
                candidatethird, candidatefourth, candidatefifth};

            foreach (Candidate c in Allcandidates) 
            {
                Console.WriteLine(c.person.address.street);
            
            }
            int maxScore = 0;
            foreach(Candidate c in Allcandidates)
            {
                
                if (c.subjectScore[0].score > maxScore)
                    {
                    maxScore = c.subjectScore[0].score;
                     }
            }
            Console.WriteLine(maxScore);

        }
    }
}