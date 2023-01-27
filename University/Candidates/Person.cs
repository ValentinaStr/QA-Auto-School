﻿namespace University.Candidates
{ 
	public class Person
    {
        public const int MaxLenghtNameLastName = 20;
		private string _name = "";
        private string _lastName = "";
        private Address _address;
        public string Name{get { return _name;}
            set
            {
                _name = value ?? throw new ArgumentNullException("Name can not be Null");

				if (LenghtNameLastName > MaxLenghtNameLastName)
				{
					throw new ArgumentException("Wrong lenght Name or Lastname");
				}
            }
        }
        public string LastName
        { 
            get { return _lastName;}
            set
            {
				_lastName = value ?? throw new ArgumentNullException("Lastname can not be Null");
                
				if (LenghtNameLastName > MaxLenghtNameLastName)
				{					
					throw new ArgumentException("Wrong lenght Name or Lastname");
                }
			}
        }
        public int LenghtNameLastName => _lastName.Length + _name.Length;

		public Address Address 
        {
            get { return _address; }
            set { _address = value ?? Address.NoAddress; }
        }

        public Person(string name, string lastname, Address address)
        {
           	Name = name;
            LastName = lastname;
            Address = address;
        }
	}
}
