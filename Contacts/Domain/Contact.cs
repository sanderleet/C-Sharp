using System;

namespace Domain
{
    public class Contact
    {
        private static int _id;

        public int ContactId { get; set; }

        public Contact()
        {
            _id++;
            ContactId = _id;
        }
        public string ContactValue { get; set; }

        public ContactType ContactType { get; set; }
        
        public int ContactTypeId { get; set; }

        public Person Person { get; set; }
    }
}
