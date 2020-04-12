using System;

namespace Hello_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool exit = menu.MainMenu();
            if(!exit)
                Console.WriteLine("Thank You");
        }
    }
}
