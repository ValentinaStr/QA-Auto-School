namespace University.Candidates
{ 
	public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string name, string lastname, Address address)
        {
			if (name.Length + lastname.Length > 20)
			{
				throw new ArgumentException("Wrong lenght Name or Lastname");
			}
			Name = name;
            LastName = lastname;
            Address = address;
        }

    }
}
