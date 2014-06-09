using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class MyAgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");
            int birthDate = Convert.ToInt16(Console.ReadLine());
            int realAge = DateTime.Now.Year - birthDate;
            Console.WriteLine("Your age now is: {0}", realAge);
            Console.WriteLine("Your age after 10 years will be: {0}", realAge + 10);
        }
    }
}
