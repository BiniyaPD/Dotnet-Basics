using Assessment1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1.Repository
{
    public interface IContactRepo
    {
        bool AddContacts(Contact contact);
       
        IEnumerable<Contact> GetContacts();
        bool UpdateContactByName(Contact contact);
        Contact GetContactByMob(string mobileNo);

        Contact GetContactByName(string name);
        
    }
}
