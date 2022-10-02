using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Task16_Delegate
    {
        /// <summary>
        /// Creating a Delegate for the Interest Calculation
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="interest_rate"></param>
        public delegate void Multicast_Delegate(string bankName, double interest_rate);
        
        /// <summary>
        /// Class creation
        /// </summary>
        public class calculation1
        {
            /// <summary>
            /// Creating a Method with the same signature as the delegate
            /// </summary>
            /// <param name="bankName"></param>
            /// <param name="interest_rate"></param>
            public void Interes1_details(string bankName, double interest_rate)
            {
                Console.WriteLine($"{bankName} : {interest_rate}");
            }
            public void calculating_intrest(string bankName, double interest_rate)
            {
                Console.WriteLine($"{bankName} : The Interset with Amount is =  {3000+(3000*interest_rate)/100}");
            }
        }

        public static void Main()
        {
            //Creating an instance for the class
            calculation1 c = new calculation1();
            //Creating a Delegate instance
            Multicast_Delegate md = c.Interes1_details;
            //Multi-Cast Delegate
            md+=c.calculating_intrest;
            //Calling a Bank Name and Interest
            md("SBI", 2.70);
            Console.WriteLine("----------------------------------------");
            md("HDFC Bank", 3.00);
            md("HDFC Bank", 3.50);
            Console.WriteLine("----------------------------------------");
            md("Kotak Mahindra Bank",3.50);
            Console.WriteLine("----------------------------------------");
            md("Axis Bank",3.00);
            md("Axis Bank", 3.50);
            Console.WriteLine("----------------------------------------");
            md("ICICI Bank",3.00);
            md("ICICI Bank", 3.50);
            Console.WriteLine("----------------------------------------");

        }
    }
}
