using Assessment1.Models;
using Assessment1.Repository;
using System;
using System.Collections.Generic;

namespace Assessment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IContactRepo contactRepo = new ContactRepositoryListImpl();
            //1.create contacts
            Contact contact1 = new Contact() { ContactName = "Biniya" ,MobileNumber="8778432345",Email= "biniya@gmail.com" };
            Contact contact2 = new Contact() { ContactName = "Nivya", MobileNumber = "8712332345", Email = "nivya@gmail.com" };
            Contact contact3 = new Contact() { ContactName = "Aljo", MobileNumber = "9965432345", Email = "aljo@gmail.com" };
            Contact contact4 = new Contact() { ContactName = "Amal", MobileNumber = "7125432345", Email = "amal@gmail.com" };
            Contact contact5 = new Contact() { ContactName = "Antony", MobileNumber = "8905432345", Email = "antony@gmail.com" };

            //2.Add Contacts to Contact list
            contactRepo.AddContacts(contact1);
            contactRepo.AddContacts(contact2);
            contactRepo.AddContacts(contact3);
            contactRepo.AddContacts(contact4);
            contactRepo.AddContacts(contact5);

            //3.DisplayContact
            DisplayContacts(contactRepo);

          
            //4.Get Contact by Id
            DisplayContactByMobile(contactRepo);


            //5.Get Contact by Name
            DisplayContactByName(contactRepo);

            //6.Update Contact
            UpdateContactByName(contactRepo);
        }

        private static void DisplayContactByName(IContactRepo contactRepo)
        {
            string name = "Nivya";
            var contact = contactRepo.GetContactByName(name);
            if (contact == null)
            {
                Console.WriteLine($"Contact with {name}  does not exists");
            }
            else
            {
                Console.WriteLine($"Contact By Name: {name}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name:{contact.ContactName}\tMobile Number{contact.MobileNumber}\tEmail:{contact.Email}");
                Console.WriteLine();
            }
            
        }

        private static void DisplayContactByMobile(IContactRepo contactRepo)
        {
            string mobileNumber = "8905432345";
            var contact = contactRepo.GetContactByMob(mobileNumber);
            if(contact==null)
            {
                Console.WriteLine($"Contact with {mobileNumber} number does not exists");
            }
            else
            {
                Console.WriteLine($"Contact By Mobile Number: {mobileNumber}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Name:{contact.ContactName}\tMobile Number{contact.MobileNumber}\tEmail:{contact.Email}");
                Console.WriteLine();
            }
           
        }

        private static void UpdateContactByName(IContactRepo contactRepo)
        {
            string updateByName = "Amal";
            var updateContact = contactRepo.GetContactByName(updateByName);
            bool isUpdated=contactRepo.UpdateContactByName(updateContact);
            if(isUpdated==true)
            {
                Console.WriteLine($"The Contact info of {updateByName} is Updated Successfully");
                foreach (var contact in contactRepo.GetContacts())
                {
                    Console.WriteLine($"{contact.ContactName}\t{contact.MobileNumber}\t{contact.Email}");
                }
            }
            else
            {
                Console.WriteLine("Contact Not Updated");
            }
        }

        private static void DisplayContacts(IContactRepo contactRepo)
        {
            Console.WriteLine("Contact Information");
            Console.WriteLine("----------------------");
            Console.WriteLine("Name\tMobileNumber\tEmail");
            foreach (var contact in contactRepo.GetContacts())
            {
                Console.WriteLine($"{contact.ContactName}\t{contact.MobileNumber}\t{contact.Email}");
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }
    }
}
