using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city) // parametreli constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public Customer()// default constructor parametresi yok!
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
    }
}
