using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Task14_Regular_Expression
    {
        public static void Main()
        {
            //Callng a static method
            Mobile_Validation();
        }
        /// <summary>
        /// Creating a satatic method For Validation of regular expression
        /// </summary>
        public static void Mobile_Validation()
        {
            //Taking the User Input
            Console.WriteLine("Enter the Mobile Number for validation");
            string mobile_no=Console.ReadLine();
            //Regular expression for matching the pattern
            var validation = Regex.IsMatch(mobile_no, @"^[7-9][0-9]{9}$");
            Console.WriteLine(validation); 
        }
    }
}
