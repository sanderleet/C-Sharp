using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public class Context
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public List<ContactType> ContactType { get; set; } = new List<ContactType>();
    }
}
