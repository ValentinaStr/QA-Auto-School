namespace DataTypesIntro
{
	internal class Person
	{
		public string Name;
		public string Surname;
		public Address Address;

		public Person(string name, string surname, Address address)
		{
			this.Name = name;
			this.Surname = surname;
			this.Address = address;
		}
		
	}
}
