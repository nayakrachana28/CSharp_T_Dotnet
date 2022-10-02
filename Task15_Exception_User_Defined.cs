using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Create a User_defined Exception for the age validation
    /// </summary>
    public class age_validation:ApplicationException
    {
        /// <summary>
        /// Constructor creation
        /// </summary>
        /// <param name="message"></param>
        public age_validation(string message):base(message)
        {

        }
    }
    internal class Task15_Exception_User_Defined
    {
        public static void Main()
        {
            //try and catch block to throw an exception
            try
            {
                Console.WriteLine("Enter the age for Eligibility check");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 22)
                {

                    Console.WriteLine("You are Eligible");
                }
                else
                {
                    //Throws an exception
                    throw (new age_validation("Your are Not Eligible..... Check the age criteria"));
                }
            }
            catch (age_validation e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
