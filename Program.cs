using DataTypesIntro.Candidates;
internal class Program
{
    private static void Main(string[] args)
    {
        Candidate candidateFirst = new(
            new Person("William", "Jordan", 
            new Address("London", "Carnaby Street", 25, 30)),
            new SubjectScore[] {
                new SubjectScore("Maths", 50),
                new SubjectScore("Physics", 30),
                new SubjectScore("Foreign language", 60),
                new SubjectScore("Literature", 25),
                new SubjectScore("Music", 20)
            });
        Candidate candidateSecond = new(
            new Person("Liam", "Peters",
            new Address("London", "Shaftesbury Avenue", 10, 13)),
            new SubjectScore[] {
                new SubjectScore("Maths", 10),
                new SubjectScore("Physics", 30),
                new SubjectScore("Foreign language", 60),
                new SubjectScore("Literature", 75),
                new SubjectScore("Music", 80)
            });
        
        Candidate candidateThird = new(
            new Person("Maksim", "Ivanov",
            new Address("Minsk", "Zybickaja", 20, 3)),
            new SubjectScore[]{
                new SubjectScore("Maths", 10),
                new SubjectScore("Physics", 30),
                new SubjectScore("Foreign language", 60),
                new SubjectScore("Music", 80)
            });
        Candidate candidateFourth = new(
            new Person("Victoria", "Zakharova",
            new Address("Beijing", "Chang`an", 123, 357)),
            new SubjectScore[]{
                new SubjectScore("Maths", 90),
                new SubjectScore("Physics", 70),
                new SubjectScore("Foreign language", 95),
                new SubjectScore("Literature", 85),
                new SubjectScore("Music", 87)
            });
        Candidate candidateFifth = new(
            new Person("Anna", "Stone",
            new Address("Minsk", "Pervomaiskaya", 23, 35)),
            new SubjectScore[]{
                new SubjectScore("Maths", 70),
                new SubjectScore("Physics", 60),
                new SubjectScore("Foreign language", 75),
                new SubjectScore("Literature", 85),
                new SubjectScore("Music", 87)
            });
        
        Candidate[] allCandidates = new Candidate[]{
            candidateSecond,
            candidateThird,
            candidateFourth,
            candidateFifth
        };
        
        void GetStreet(Candidate[] one)
        {
            foreach (Candidate candidate in one)
            {
                Console.WriteLine(candidate.GetStreet());
            }
        }
        
        GetStreet(allCandidates);
        
        string subjectName = "Maths";
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
        Console.WriteLine(maxScoreSubject + " " + candidateLastnameMaxScore);
    }
}
