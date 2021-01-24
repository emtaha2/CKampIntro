using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        private Customer customer;

        public CustomerManager(Customer customer)
        {
            this.customer = customer;
        }

        public void Welcome()
        {
            Console.WriteLine(" Hoşgeldiniz:) " + this.customer.NameSurname);
            Console.WriteLine(" Kişisel Bigiler :" + " Yaşınız : " + this.customer.Age);
        }

        public void Requid()
        {
            int requiredAge = 18;

            if (requiredAge < this.customer.Age)
            {
                Console.WriteLine("Başvuru Durumu Olumlu");
            }
            else
            {
                Console.WriteLine("Başvuru Durumu Olumsuz");
            }

        }
        public void Update()
        {
            Console.WriteLine(this.customer.Id + " Müşteri hesabı oluşturuldu!");

        }
        public void Delete()
        {
            Console.WriteLine(this.customer.Age + " Müşteri başvurusu reddedildi!");
        }
    }
}
