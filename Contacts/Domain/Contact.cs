using System;

namespace Domain
{
    public class Contact
    {
        private static int _id;

        public int ContactId { get; set; }

        public Contact(ContactType contactType, Person person)

        {
            _id++;
            ContactId = _id;
            ContactType = contactType;
            Person = person;
            Person.Contacts.Add(this);

        }
        public string ContactValue { get; set; }

        public ContactType ContactType { get; set; }
        
        public int ContactTypeId { get; set; }

        public Person Person { get; set; }
    }
}
