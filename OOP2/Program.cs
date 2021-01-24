using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Customer customer1 = new Customer();
            //    customer1.Name = "Sena";
            //    customer1.Surname = "Uğur";
            //    customer1.Id = 1;
            //    customer1.IdNo = "125415625470";
            //    customer1.CustomerNo = "110025";
            //    customer1.CompanyName = "!";


            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "0001";
            customer1.Name = "Sena";
            customer1.Surname = "Uğur";
            customer1.TcNo = "12345678912";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "00021";
            customer2.CompanyName = "CTC";
            customer2.TaxNo = "12385214";



            //SOLID
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer1);

        }
    }
}
