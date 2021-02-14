using ReferansTypes;
using System;

namespace ReferansTyoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            Person person2 = new Person();

            person1.Adi = "Mustafa";

            person2 = person1;

            person1.Adi = "Burak";
            Console.WriteLine(person2.Adi);

            Person person3 = new Person();

            Customer customer = new Customer();
            customer.Adi = "Salih";
            customer.CreditCardNumber = 1234567890;

            Employee employee = new Employee();
            employee.Adi = "Veli";


            person3 = customer;

            Console.WriteLine(person3.Adi);

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            Console.WriteLine(employee.Adi);
        }
    }
}
