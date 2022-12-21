using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class Last_Name
    {
        public void Lastname()
        {
            Console.WriteLine("Enter Last Name");
            var data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Last Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Last Name");
                Console.ResetColor();
            }
        }
    }
}
