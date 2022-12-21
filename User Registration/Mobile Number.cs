using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class Mobile_Number
    {
        public void MobileNumber()
        {
            Console.WriteLine("Enter Mobile Number ");
            var data=Console.ReadLine();
            string pattern = "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
            Regex regex=new Regex(pattern);
            if(regex.IsMatch(data))
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(data + " is valid mobile number");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(data+" is invaild mobile number");
                Console.ResetColor();
            }

        }
    }
}
