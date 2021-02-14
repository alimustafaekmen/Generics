using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // default constructor parametresi olmayan constructor

            Customer customer1 = new Customer { Id = 1, FirstName = "Mustafa", 
                LastName = "Ekmen", City = "İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "dfgdfg";
            customer3.LastName = "dgdfg";

            //parametereli constructor
            Customer customer2 = new Customer(2,"Mustafa","Ekmen","Ankara");

            Console.WriteLine(customer2.FirstName);

            
        }
    }
}
