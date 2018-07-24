using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Email, Date, PhoneNumber;

            //validates name
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine(Verify(Name, @"^[A-Z]{1}[A-Za-z]{0,29}$", "Error- Please enter a valid name: ", "That is a valid Name"));

            //validates email
            Console.Write("Enter your email: ");
            Email = Console.ReadLine();
            Console.WriteLine(Verify(Email, @"^[A-Za-z\d]{5,30}@[a-z\d]{5,10}[.][a-z\d]{2,3}$", "Error- Please enter a valid email: ", "That is a valid Email"));

            //validates phone num
            Console.Write("Enter your phone number (###-###-####): ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine(Verify(PhoneNumber, @"^\d{3}-\d{3}-\d{4}$", "Error- Please enter a valid phone number: ", "That is a valid Phone Number"));

            //validates dates
            Console.Write("Enter your birthdate (mm/dd/yyyy): ");
            Date = Console.ReadLine();
            Console.WriteLine(Verify(Date, @"^\d{2}/\d{2}/\d{4}$", "Error- Please enter a valid date: ", "That is a valid Date"));
            Console.ReadKey();
        }
        
        public static string Verify (string input, string verification, string Message, string Message2)
        {
            while (!Regex.IsMatch(input, verification))
            {
                Console.Write(Message);
                input = Console.ReadLine();
            }
            return Message2;
        }

    }
}
