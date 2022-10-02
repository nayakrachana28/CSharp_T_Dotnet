using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Creating a class
    /// </summary>
    internal class Multiple_Catch
    {
        /// <summary>
        /// Multiple catch block which except a exception handling
        /// </summary>
        public void catch1()
        {
            try
            {
                Console.WriteLine("Enter the value that is number");
                int n=Convert.ToInt32(Console.ReadLine());
                if (45 % n == 0)
                {
                    Console.WriteLine("{0} is the factor of 45",n);
                }
            }
            //First catch block
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                //Properties of Catch block
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                //Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HResult);
            }
            //Second catch block
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                //Properties of Catch block
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                //Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HResult);
            }
            //Third Catch block
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                //Properties of Catch block
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.TargetSite);
                //Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HResult);
            }
        }
        public void catch2()
        {
            //Secound example for multiple catch block
            int[] array1 = { 2, 4, 5, 6, 7, 8 };
            int[] array2 = { 0, 4, 0, 3, 1 };
            for (int i = 0; i < array1.Length; i++)
            {
                try
                {
                    Console.WriteLine(array1[i]/array2[i]); 
                }
                //First Catch Block
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Second Catch Block
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    internal class Task15_Exception_Catch_Block
    {
        public static void Main()
        {
            Multiple_Catch mc1 = new Multiple_Catch();
            mc1.catch1();
            Console.WriteLine("-----------------------------------------------");
            mc1.catch2();
        }
    }
}
