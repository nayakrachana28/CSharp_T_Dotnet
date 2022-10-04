using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal sealed class read_first_line
    {
        public void write()
        {
            File.WriteAllText(@"C:\Files_Csharp_Example\Main_file.txt", "Hello This is the First line of the file");
            //Console.WriteLine("\n");
            //File.AppendAllText(@"C:\Files_Csharp_Example\Main_file.txt", "Hello This is the appended line of the file"+Environment.NewLine);
            Console.WriteLine("Reading a Single Line:");
            string[] read_line=File.ReadAllLines(@"C:\Files_Csharp_Example\Main_file.txt");
            Console.WriteLine(read_line[0]);
            Console.WriteLine("----------------------------------");
            string[] read_all_line1 = File.ReadAllLines(@"C:\Files_Csharp_Example\TE4.txt");
            Console.WriteLine("Counting the number of lines ina file TE4 : "+read_all_line1.Length);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Reading a Multiple lines Line:");
            string[] read_all_line = File.ReadAllLines(@"C:\Files_Csharp_Example\TE4.txt");
            for(int i = 0; i < read_all_line.Length; i++)
            {
                Console.WriteLine(read_all_line[i]);
            }
           
            
        }

    }
    internal class Task17_file_operation
    {
        public static void Main()
        {
            //Move a file from one Place to another place
            //File.Move(@"C:\Files_Csharp_Example\TE1.txt", @"C:\Files_Csharp_Example\moving\TE1.txt");

            //Copy of file from one location to another location
            //File.Copy(@"C:\Files_Csharp_Example\TE3.txt", @"C:\Files_Csharp_Example\moving\TE3.txt");

            //Delete a File
            //File.Delete(@"C:\Files_Csharp_Example\TE_delete.txt");

            read_first_line rfl=new read_first_line();
            rfl.write();
        }
    }
}
