using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer sınıfını newlediğimiz zamana defaul constructor çalışır.
            Customer customer = new Customer();
            Customer customer1 = new Customer { Id = 1, FirstName = "İshak", LastName = "Selvitopu", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {
            //Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        //custormer2 nin çalışması için bu şekilde tanımlama yapılır.
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
