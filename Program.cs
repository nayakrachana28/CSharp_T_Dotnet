using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Hello");
            two_array();
        }

        public static void two_array()
        {
            int[,] array1 = new int[,] 
            { 
                {1, 2},
                {3, 4}
            };

            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i,j]);
                }
            }
        }
    }
}

