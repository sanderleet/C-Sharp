using System;
using System.Collections.Generic;

namespace Domain
{

    /// <summary>
    /// This is class for Person
    /// </summary>
    public class Person
    {
        private string _firstName;
        private string _lastName;

        private static int _id;
        public  int PersonId { get; private set; }

        public Person()
        {
            _id++;
            PersonId = _id;
        }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = ValidateNameString(value, nameof(FirstName));
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = ValidateNameString(value, nameof(LastName));

        }
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public string FirstLastName => $"{FirstName} {LastName}";
        public string LastFirstName => $"{LastName} {FirstName} ";

        private static string ValidateNameString(string name, string fieldName)
        {
            if (name.Length < 1)
            {
                throw new ArgumentException($"{fieldName} is too short");
            }
            return name[0].ToString().ToUpper().Length + name.ToLower().Substring(1);
        }

        public override string ToString()
        {
            return FirstLastName + " (ID: " + PersonId + ")";
        }
    }
}
