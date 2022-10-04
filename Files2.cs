using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class File_concepts2
    {
        public void file_1()
        {
            string Path = @"C:\Files_Csharp_Example\TE1.txt";
            File.WriteAllText(@"C:\Files_Csharp_Example\TE1.txt", "Here is the New files with some content on it .........");
            //File.OpenWrite(Path);
            //File.AppendAllText(Path, "Hello This is the Secong line of the content");
           //Copy of the file is created
            //File.Copy(Path, @"C:\Files_Csharp_Example\TE3.txt");

            //string readtext= File.ReadAllText(@"C:\Files_Csharp_Example\TE1.txt");
            //Console.WriteLine(readtext);
            //string[] r1 = File.ReadAllLines(Path);
            //Console.WriteLine(r1[0]);
            FileInfo fi=new FileInfo(Path); 
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.LinkTarget);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Exists);


        }
        public void directory_demo()
        {
            string str1 = @"C:\Files_Csharp_Example\";
            foreach (var file in Directory.GetFiles(str1))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("--------------------------------------");
            
            foreach (var file in Directory.GetDirectories(@"C:\"))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("--------------------------------------");
            foreach (var file in Directory.EnumerateFiles(str1))
            {
                Console.WriteLine(file);
            }

            StreamWriter s= File.CreateText(@"C:\Files_Csharp_Example\TE4.txt");
            s.WriteLine("This is created using the files");
            s.Close();

        }
    }
    internal class Files2
    {
        public static void Main()
        {
            File_concepts2 fc2 = new File_concepts2();
            //fc2.file_1();
            fc2.directory_demo();
        }
    }
}
