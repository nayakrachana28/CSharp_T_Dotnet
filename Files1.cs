using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// In files we use filestream which is already created in environment.
    /// Filestream - two class- Streamreader( For Reading) StreamWriter ( For Writing )
    /// Stream is the abstract class which is in system.IO.Stream
    /// </summary>
    public class Files_concepts
    {
        /// <summary>
        /// Write the data to the file using Stream Writer
        /// </summary>
        public void Write()
        {
            //Fileinfo=which specify the name of the file
            //Create the fileinfo instance
            //To create a file and the open the Mode should be openorcreate
            FileInfo fileInfo = new FileInfo(@"C:\Files_Csharp_Example\TE.txt");
            FileStream fileStream= fileInfo.Open(FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
            fileStream.WriteByte(65);
            //fileStream.Write(1,2,1);
            StreamWriter writer= new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Welcome for the First file concepts");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        public void read()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Files_Csharp_Example\TE.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
            StreamReader reader= new StreamReader(fileStream);
            try
            {
                //Which read to the console
                //ReadLine reads a single Line
                //string line = reader.ReadLine();
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
                //Console.WriteLine(line);
                /*string line1 = "";
                while ((line1 = reader.ReadLine()) != null){
                    Console.WriteLine(line1);
                }*/
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }
        }
        /// <summary>
        /// To avoid overwritten we need append operation
        /// </summary>
        public void append()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Files_Csharp_Example\TE.txt");
            FileStream fileStream = fileInfo.Open(FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
            StreamWriter append=new StreamWriter(fileStream);
            try
            {
                append.WriteLine("Hello this is appended one................");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                append.Close();
                fileStream.Close();
            }
        }
    }
    internal class Files1
    {
        public static void Main()
        {
            Files_concepts fc=new Files_concepts();
            fc.Write();
            fc.read();
            //fc.append();
        }
    }
}
