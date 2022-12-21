using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class Password
    {
        public void pass()
        {
            Console.WriteLine("Enter Password");
            var data = Console.ReadLine();
            string pattern = "^+[A-Za-z]{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is a Valid Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is a Invalid Password");
                Console.ResetColor();
            }
        }
    }
}
