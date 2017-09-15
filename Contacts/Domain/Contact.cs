using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ContactType ContactType { get;
            _id++;
            ContactTypeId = _id; set; }


        public Person Person { get; set; }
    }
}
