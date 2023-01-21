namespace AddBuilding
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string name, string lastname, Address address)
        {
            Name = name;
            LastName = lastname;
            Address = address;
        }

    }
}
