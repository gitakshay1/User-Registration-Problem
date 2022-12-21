using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    internal class First_Name
    {
        public void FirstName()
        {
            Console.WriteLine("Enter Firts Name");
            var data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Name");
                Console.ResetColor();
            }
        }
    }
}
