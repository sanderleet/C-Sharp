using System;
using DAL;
using Domain;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (;;)
            {
                var ctx = new Context();
                ctx.Persons.Add(new Person(){FirstName = "Sander", LastName = "Valgo"});
                ConsoleKeyInfo input;
                do
                {
                    Console.WriteLine("PhoneBook");
                    Console.WriteLine("----------");
                    Console.WriteLine("List of all contacts");
                    Console.WriteLine("Add Contacts");
                    Console.WriteLine("Exit");
                    input = Console.ReadKey();
                    Console.WriteLine();
                    switch (input.KeyChar)
                    {
                        case 'L':
                            foreach (var person in ctx.Persons)
                            {
                                Console.WriteLine(person.FirstLastName);
                            }
                            break;

                        case 'A':
                            Console.Write("Firstname: ");
                            var firstName = Console.ReadLine();
                            Console.Write("Last Name: ");
                            var lastName = Console.ReadLine();
                            try
                            {

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            ctx.Persons.Add(new Person() {FirstName = firstName, LastName = lastName});
                            break;

                        default:

                            break;
                    }
                } while (input.KeyChar != 'E' && input.KeyChar != 'X');
                return;
            }
        }

        
    }
}
