using System;
using System.Collections.Generic;

namespace Domain
{
    public class ContactType
    {
        public string ContactTypeName { get; set; } //skipe, email, etc
        public List<Contact> Contacts { get; set; } = new List<Contact>();

    }
}
