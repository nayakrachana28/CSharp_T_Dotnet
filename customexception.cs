using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// User-defined exception
    /// Here In user defined exception create a class
    /// we need to inherite the class from either ApplicationException/Exception
    /// Step1 : Create a User-defined exception class
    /// Step2 : Create a Constructor for the Class
    /// </summary>
    public class marksless:ApplicationException
    {
        /// <summary>
        /// Constructor
        /// If there Base is not metioned than it will not retrive the error and give to application thet the  error I gave it will give its error
        /// </summary>
        /// <param name="message"></param>
        public marksless(string message):base(message)
        {

        }
    }
    internal class customexception
    {
        public static void Main()
        {
            int marks;
            try
            {
                Console.WriteLine("Enter the Marks");
                marks=Convert.ToInt32(Console.ReadLine());
                if (marks < 32)
                {
                    throw new marksless("Your Marks is less and Your Fail");
                }
                else
                {
                    Console.WriteLine("You are pass");
                }
            }
            catch(marksless e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
