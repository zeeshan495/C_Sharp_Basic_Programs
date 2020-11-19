using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_User
{
    //Hello
    class Person
    {
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName +" "+ LastName;
        }
        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                format = "FL";
            switch (format)
            {
                case "FL":
                    return FirstName + " " + LastName;
                case "LF":
                    return LastName + " " + FirstName;
                case "F,L":
                    return FirstName + ", " + LastName;
                case "L,F":
                    return LastName + ", " + FirstName;
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported",format));
            }
        }
    }
}
