using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    
    internal class Task18_Generics
    {
        public delegate T areas_cal<T>(T value);

        public class areas
        {
            public int areasquare(int value)
            {
                
                return value * value;
              
            }
            public int areacube(int value)
            {
                return value * value * value;
            }
            public int areacircle(int value)
            {
                return (22/7)*value*value;
               
            }


            public double areasquare(double value)
            {

                return value * value;

            }
            public double areacube(double value)
            {
                return value * value * value;
            }
            public double areacircle(double value)
            {
                return (22 / 7) * value * value;

            }

        }
            public static void Main()
            {
             areas a=new areas();
            areas_cal<int> acd = a.areasquare;
            Console.WriteLine("Taking Interger Value");
            Console.WriteLine("Area of square : ");
            Console.WriteLine(acd(20));
            Console.WriteLine("---------------------------------------");
            acd = a.areacube;
            Console.WriteLine("Area of Cube : ");
            Console.WriteLine(acd(20));
            Console.WriteLine("---------------------------------------");
            acd = a.areacircle;
            Console.WriteLine("Area of Circle : ");
            Console.WriteLine(acd(20));
            Console.WriteLine("---------------------------------------");


            areas_cal<double> acd1 = a.areasquare;
            Console.WriteLine("Taking Double Value");
            Console.WriteLine("Area of square : ");
            Console.WriteLine(acd1(25.5));
            Console.WriteLine("---------------------------------------");
            acd1 = a.areacube;
            Console.WriteLine("Area of Cube : ");
            Console.WriteLine(acd1(25.5));
            Console.WriteLine("---------------------------------------");
            acd1 = a.areacircle;
            Console.WriteLine("Area of Circle : ");
            Console.WriteLine(acd1(25.5));
            Console.WriteLine("---------------------------------------");
        }

    }
}
