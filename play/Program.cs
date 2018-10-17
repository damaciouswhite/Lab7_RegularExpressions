using System;
using System.Text.RegularExpressions;

namespace play
{
    class Program
    {
        static void Main(string[] args)
        {

            string UserName = NameValidation();
            string EmailName = EmailValidation(UserName);
            string PhoneNumber = PhoneValidation();
            string Date = DateValidation();
        }

        public static string NameValidation()
        {
            Console.WriteLine("Lab 7 Regular Expressions");
            Console.WriteLine("-------------------------");
            //getting the input
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();

            //processing/the actual validation
            if (Regex.IsMatch(UserName, @"^[A-Z]+[A-z]{2,30}$") == false)
            {
                Console.WriteLine("I am sorry! That is not a name.");
                UserName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Thank you {0}", UserName);
            }

            //output
            return UserName;
        }

        public static string EmailValidation(string UserName)
        {
            Console.WriteLine("Please Enter a Valid Email Address");
            string EmailName = Console.ReadLine();

            if (Regex.IsMatch(EmailName, @"^([A-z0-9]{5,30})@([A-z0-9]{5,10}).([A-z0-9]{2,3})$") == false)
            {
                Console.WriteLine("This Is Not a Valid Email.");

            }

            else
            {
                Console.WriteLine("Thank You {0}, You Entered {1}.", UserName, EmailName);
            }

            return EmailName;
        }

        public static string PhoneValidation()
        {
            Console.WriteLine("Please Enter a Phone Number (###-###-####) ");
            string PhoneNumber = Console.ReadLine();

            if (Regex.IsMatch(PhoneNumber, @"^([0-9]{3})-([0-9]{3})-([0-9]{4})$") == false)
            {
                Console.WriteLine("This Is Not a Valid Phone Number");
            }

            else

            {
                Console.WriteLine("Thank You. You Entered {0}", PhoneNumber);
            }

            return PhoneNumber;
        }

        public static string DateValidation()
        {
            Console.WriteLine("Please Enter a Date(MM/DD/YYYY)");
            string Date = Console.ReadLine();

            if(Regex.IsMatch(Date, @"^\d{1,2}/\d{1,2}/\d{4}$")==false)
            {
                Console.WriteLine("Sorry date is not valid!");
            }
            else
            {
                Console.WriteLine("Thanks, you entered {0}", Date);
            }

            return Date;
        
        }

        }
        }