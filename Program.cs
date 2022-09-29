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
            //this is giving the details of the array manually
            //two_array();
            //Here the user is giving the array values and then adding the array
            Console.WriteLine("Addition of Matrix using 2-D Array");
            add_array2();

            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Multiplication table operation using params array");

            mul_param(1,2);

            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Get the student details using Out");
            //Out Keyword
            //int stuid;
            string stuname, studep;
            //This out keyword is uses to access more than one return type
            out_keyword(out int stuid, out stuname, out studep);
            Console.WriteLine($"Details : {stuid} : {stuname} : {studep}");
        }
        /// <summary>
        /// Using the out keyword to get the student id,name,department
        /// If we want to return more than one value use out keyword
        /// </summary>
        public static void out_keyword(out int sid,out string sname,out string sdep)
        {
            Console.WriteLine("Enter the student Id");
            sid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student Name");
            sname = Console.ReadLine();
            Console.WriteLine("Enter the student Department");
            sdep = Console.ReadLine();



        }

        public static void mul_param(params int[] numbers)
        {
            foreach (var num in numbers)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(num + " * " + (i + 1) + " = " + num * (i + 1));
                }
                Console.WriteLine("\n");
            }
        }

        public static void two_array()
        {
            int[,] array1 = new int[,] 
            { 
                {1, 2},
                {3, 4}
            };

            int[,] array2 = new int[,]
            {
                {1, 2},
                {3, 4}
            };

            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i,j] = array2[i,j]+array1[i,j];
                }
            }

            for(int l=0;l< array1.GetLength(0);l++)
            {
                for(int k = 0; k < array1.GetLength(1);k++)
                {
                    Console.Write(array1[l,k]+"\t");
                }
                Console.WriteLine("\n");
            }
        }


        public static void add_array2()
        {
            int max = 3;
            int[,] array1 = new int[20,20];
            int[,] array2 = new int[20,20];
            int[,] array3 = new int[20,20];

            Console.WriteLine("Enter the first array  element");
            for(int i = 0; i < max; i++)
            {
                for( int j = 0; j < max; j++)
                {
                    array1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The first array element are");
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(array1[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Enter the Second array  element");
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Secoud array element are");
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    array3[i, j] = array1[i, j] + array2[i,j];
                }
            }
            Console.WriteLine("The Addition of two array element are");
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(array3[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }

        
    }
}

