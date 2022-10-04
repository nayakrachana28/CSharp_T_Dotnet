using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public sealed class mul_file1
    {
        public void multiplication_table()
        {
            //Console.WriteLine("Enter the Number for which You want the Multiplication table");
            //int num=Convert.ToInt32(Console.ReadLine());

            using(StreamWriter sw1=File.CreateText(@"C:\Files_Csharp_Example\TE7_Multiplication.txt"))
            {

                for (var j = 1; j < 11; j++)
                {
                    for (var i = 1; i < 11; i++)
                    {
                        sw1.WriteLine($"{j} * {i} = {j * i}");
                    }
                   // Console.Write("\n");
                }
                
            }
        }

        public void read_multiplication_()
        {
            using (StreamReader sr=File.OpenText(@"C:\Files_Csharp_Example\TE7_Multiplication.txt"))
            {
                string lines = "";
                while((lines=sr.ReadLine())!=null)
                  {
                    Console.WriteLine(lines);
                }
            }
        }
    }
    internal class Task17_files1
    {
        public static void Main()
        {
            mul_file1 m=new mul_file1();
            m.multiplication_table();
            m.read_multiplication_();
        }
    }
}
