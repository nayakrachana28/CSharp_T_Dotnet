using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// When ever used sealed we cannot inherit the class
    /// The other class cannot inherit the class which is havig the sealed keyword
    /// </summary>
    public sealed class using_file_concepts
    {
        public int sum = 0;
       public void using_demo()
        {
            //Using -> Resource management
            //Using keyword would dispose or free the resource
            //By using keyword use no need to close the file explicity which is open by default it will close
            //Here it will create a File TE5.txt
            using (StreamWriter s = File.CreateText(@"C:\Files_Csharp_Example\TE5.txt"))
            {
                for(int i=0; i < 5; i++)
                {
                    s.WriteLine($"Loop : {i+1} : {sum+=i}");
                }
            }
        }
        public void using_demo_read()
        {
            using(StreamReader sr=File.OpenText(@"C:\Files_Csharp_Example\TE5.txt"))
            {
                //string lines = "";
                string? lines = null;
                while ((lines = sr.ReadLine())!=null)
                {
                    Console.WriteLine(lines);   
                }
            }
        }
    }
    internal class File3
    {
        public static void Main()
        {
            using_file_concepts ufc=new using_file_concepts();
            ufc.using_demo();
            ufc.using_demo_read();
        }
    }
}
