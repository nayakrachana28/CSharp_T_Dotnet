using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public class Exceptions
    {
        int result;
        float result1;
       
        public void divide(float num2,float num3)
        {
            try
            {
              
                //Fot float datatype with divided by zero gives the result as infinity
                result1 = num2 / num3;
                
                if(float.IsInfinity(result1))
                {
                    Console.WriteLine("Divided by Zero not allowed");
                }
                
            }
            catch(DivideByZeroException ex)
            {
           
               
            }
            finally
            {
                //Console.WriteLine(result);
                Console.WriteLine(result1);

            }
        }

      
    }

    public class exception2
    {
        public void ArrayIndex()
        {
            try
            {
                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
            }

        }
        int result3;

        public void divzero(int num1,int num2)
        {
            try
            {
                //Fot int datatype with divided by zero gives the result as 0
                result3 = num1 / num2;

                //If the exception occur this statement is not excecuted 
                //It is called only their is no execption
                Console.WriteLine("It is divisible");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error in Divided by Zero");
            }
            finally
            {
                Console.WriteLine(result3);
            }

        }

    }
    internal class Exception_Handling
    {
        public static void Main()
        {
            Exceptions exceptions = new Exceptions();
            //exceptions.divide(4, 2);
            exceptions.divide(10.04f,0);
            Console.WriteLine("-------------------------------------");
            exception2 e2=new exception2();
            e2.ArrayIndex();
            Console.WriteLine("-------------------------------------");
            e2.divzero(10, 0);
        }
    }
}
