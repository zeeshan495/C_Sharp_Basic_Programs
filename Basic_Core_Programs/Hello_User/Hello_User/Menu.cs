using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_User
{
    class Menu
    {
        public Utility utility;
        public Menu()
        {
            utility = new Utility();
        }

        public bool MainMenu()
        {
            int lInput = 0;
            bool exit = true;
            Console.WriteLine("Hello User!");
            while (exit)
            {
                Console.WriteLine("\nSelect a operation");
                Console.WriteLine("Enter 1 for Hello User");
                Console.WriteLine("Enter 2 for Flip coin");
                Console.WriteLine("Enter 3 for Leap Year");
                Console.WriteLine("Enter 4 for Harmonic Number");
                Console.WriteLine("Enter 5 for EXIT");
                try
                {
                    lInput = utility.readIntInput();
                switch (lInput)
                {
                    case 1:
                        Console.WriteLine("Hello User");
                        utility.takeName();
                        break;
                    case 2:
                        Console.WriteLine("Flip Coin");
                        utility.flip();
                        break;
                    case 3:
                        Console.WriteLine("Leap Year");
                        utility.checkLeapYear();
                        break;
                    case 4:
                        Console.WriteLine("Harmonic Numbers");
                        utility.harmonicValue();
                        break;
                    case 5:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid input");
                        break;
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return exit;
        }
    }
}
