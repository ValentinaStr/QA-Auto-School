namespace DataTypesIntro.Candidates
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, Address address)
        {
            Name = name;
            LastName = surname;
            Address = address;
        }

    }
}
