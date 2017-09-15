using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ContactType
    {
        public string ContactTypeName { get; set; } //skipe, email, etc
        public List<Contact> Contacts { get; set; } = new List<Contact>();

    }
}
