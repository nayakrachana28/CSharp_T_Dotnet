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
            FileInfo fileInfo = new FileInfo(@"C:\Files_Csharp_Example\TE.txt");
            FileStream fileStream= fileInfo.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
            StreamWriter writer= new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Welcome for the First file concepts");
            }
            catch(FileNotFoundException ex)
            {

            }

        }
    }
    internal class Files1
    {
        public static void Main()
        {

        }
    }
}
