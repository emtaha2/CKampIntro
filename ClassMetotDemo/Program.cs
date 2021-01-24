using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Random rnd = new Random();
            customer.Id = rnd.Next();

            Console.WriteLine("Müşteri Adı Soyadını giriniz: ");
            customer.NameSurname = Console.ReadLine();

            Console.WriteLine("Müşteri Telefonunu giriniz: ");
            customer.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Müşteri Adresini giriniz: ");
            customer.Adress = Console.ReadLine();


            Console.WriteLine("Yaşınızı giriniz: ");
            customer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------");

            CustomerManager customerManager = new CustomerManager(customer);
            customerManager.Welcome();
            customerManager.Requid();



            /*    Console.WriteLine("Müşteri Id : " + customer.Id);
              Console.WriteLine("Müşteri Adı Soyadı: " + customer.NameSurname);
              Console.WriteLine("Müşteri Telefon : " + customer.PhoneNumber);
              Console.WriteLine("Müşteri Adresi : " + customer.Adress);
              Console.WriteLine("Müşteri Yaşı : " + customer.Age);
              Console.WriteLine("----------------");

              CustomerManager customerManager = new CustomerManager();
              customerManager.Welcome(customer1);
              customerManager.Delete(customer2);
              customerManager.Update(customer3);
              customerManager.Requid(customer4);*/

        }
    }
}