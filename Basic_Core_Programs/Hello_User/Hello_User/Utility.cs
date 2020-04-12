using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_User
{
    class Utility
    {
        public int readIntInput()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException exception)
            {
                throw exception;
            }
        }
        public bool readStringInput(string lInput)
        {
            if (string.IsNullOrWhiteSpace(lInput))
                return false;
            else
                return true;
        }
        public void takeName()
        {
            bool isValidString = true;
            Console.WriteLine("Please enter your First name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last name");
            string LastName = Console.ReadLine();
            isValidString = readStringInput(FirstName+" "+ LastName);
            if (isValidString)
            {
                Person person = new Person(FirstName, LastName);
                replaceString(person.ToString());
            }
            else
                Console.WriteLine("Please enter valid input");
        }
        public void replaceString(string input)
        {

            Console.WriteLine("Hello "+ input + "! How are you?");
        }
        public  void flip()
        {
            Console.WriteLine("Please enter no of times");
            int numberOfTimes = readIntInput();
            int lHeads = 0, lTails = 0;
            if (numberOfTimes >= 0)
            {
                for (int flip = 1; flip <= numberOfTimes; flip++)
                {
                    if (new Random().NextDouble() < 0.5)
                        lTails++;
                    else
                        lHeads++;
                }
            }
            else
                Console.WriteLine("enter the positive integer");
            Console.WriteLine("Percentage of head " + 100.0 * lHeads / numberOfTimes);
            Console.WriteLine("Percentage of tails " + 100.0 * lTails / numberOfTimes);
        }
        public bool isLeapYear(int Year)
        {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                return true;
            else
                return false;
        }
        public void checkLeapYear()
        {
            Console.WriteLine("Please enter a year to check Leap");
            int Year = readIntInput();
            bool lLeapYear = isLeapYear(Year);
            if(lLeapYear)
                Console.WriteLine("It is a Leap year");
            else
                Console.WriteLine("It is not a leap year");
        }
        public void harmonicValue()
        {
            Console.WriteLine("Please enter a number to find out Harmonic value");
            int number = readIntInput();
            float harmonicValue = 0;
            if (number != 0)
            {
                for (int i = 1; i <= number; i++)
                    harmonicValue = ((float)1 / i) + harmonicValue;
                Console.WriteLine("the harmonic value is: " + harmonicValue);
            }
            else
                Console.WriteLine("please check the entered number");
        }
    }
}
