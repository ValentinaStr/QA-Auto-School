// See https://aka.ms/new-console-template for more information;
using DataTypesIntro;
using System.IO;

namespace ArraysNew
{    
    internal class Program
    {
        private static void Main(string[] args)
        {
            Candidate candidateFirst = new (new Person("William", "Jordan", new Address("London", "Carnaby Street", 25, 30)),
                                          new SubjectScore[] {new SubjectScore("Maths", 50), 
                                            new SubjectScore("Physics", 30),   
                                            new SubjectScore("Foreign language", 60),
                                            new SubjectScore("Literature", 25),
                                            new SubjectScore("Music", 20)});


            Candidate candidateSecond = new (new Person("Liam", "Peters",new Address("London", "Shaftesbury Avenue", 10, 13)),															 {new SubjectScores("Maths", 10),
                                           new SubjectScore[] { new SubjectScores("Physics", 30),
			                                 new SubjectScores("Foreign language", 60),
			                                 new SubjectScores("Literature", 75),
			                                 new SubjectScores("Music", 80)});

            Candidate candidatethird = new (new Person("Maksim", "Ivanov",
                                           new Address("Minsk", "Zybickaja", 20, 3)),
                                           new SubjectScore[]{new SubjectScore("Maths", 10),
                                             new SubjectScore("Physics", 30),
                                             new SubjectScore("Foreign language", 60),
                                             new SubjectScore("Literature", 75),
                                             new SubjectScore("Music", 80)});

            Candidate candidatefourth = new (new Person("Victoria", "Zakharova",
                                           new Address("Beijing", "Chang`an", 123, 357)),
                                           new SubjectScore[]{new SubjectScore("Maths", 9),
                                                new SubjectScore("Physics", 70),
                                                new SubjectScore("Foreign language", 95),
                                                new SubjectScore("Literature", 85),
                                                new SubjectScore("Music", 87)});

            Candidate candidatefifth = new (new Person("Anna", "Stone",
                                           new Address("Minsk", "Pervomaiskaya", 23, 35)),
                                           new SubjectScore[5]{new SubjectScore("Maths", 70),
                                                new SubjectScore("Physics", 60),
                                                new SubjectScore("Foreign language", 75),
                                                new SubjectScore("Literature", 85),
                                                new SubjectScore("Music", 87)});

           
            Candidate [] Allcandidates = new Candidate[]{candidateFirst, candidateSecond,
                candidatethird, candidatefourth, candidatefifth};

            foreach (Candidate c in Allcandidates) 
            {
                Console.WriteLine(c.Person.Address.Street);
            
            }


            int maxScore = 0;
            foreach(Candidate candidate in Allcandidates)
            {
                
                if (candidate.SubjectScore[0].Score > maxScore)
                    {
                    maxScore = candidate.SubjectScore[0].Score;
                     }
            }
            Console.WriteLine(maxScore);

        }
    }
}