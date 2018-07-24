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
            if (Regex.IsMatch(Name, @"^[A-Z]{1}[A-Za-z]{0,29}$"))
            {
                Console.WriteLine($"{Name} is a valid name.");
            }
            else
            {
                Console.WriteLine($"{Name} is not a valid name.");
            }

            //validates email
            Console.Write("Enter your email: ");
            Email = Console.ReadLine();
            if (Regex.IsMatch(Email, @"^[A-Za-z\d]{5,30}@[a-z\d]{5,10}[.][a-z\d]{2,3}$"))
            {
                Console.WriteLine($"{Email} is a valid email.");
            }
            else
            {
                Console.WriteLine($"{Email} is not a valid email.");
            }

            //validates phone num
            Console.Write("Enter your phone number (###-###-####): ");
            PhoneNumber = Console.ReadLine();
            if (Regex.IsMatch(PhoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine($"{PhoneNumber} is a valid phone number");
            }
            else
            {
                Console.WriteLine($"{PhoneNumber} is not a valid phone number");
            }

            //validates dates
            Console.Write("Enter your birthdate (mm/dd/yyyy): ");
            Date = Console.ReadLine();
            if (Regex.IsMatch(Date, @"^\d{2}/\d{2}/\d{4}$"))
            {
                Console.WriteLine($"{Date} is a valid date.");
            }
            else
            {
                Console.WriteLine($"{Date} is not a valid date.");
            }
            Console.ReadKey();
        }
        
        //public static string verifyName(string Name)
        //{
        //    if (Regex.IsMatch(Name, @"^[A-Z]{1}[A-Za-z]{0,29}$"))
        //    {
        //        Console.WriteLine("Correct!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong!");
        //    }
            
        //    }

    }
}
