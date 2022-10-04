using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Used for serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Training_CSharp
{
    /// <summary>
    /// Serialization in which the text is cnverted to the byte code its is mainly used for security
    /// Here two namespace is used using system.runtime.serialization and using system.runtime.serialization.formatters.binary
    /// 
    /// </summary>
    /// [Serializable] -> Type of attribute used in the concept of serialization
    [Serializable]
    internal class File4_serialization
    {
        public int employee_id;
        public string employee_name;
        public string employee_dept;
        public static void Main()
        {
            File4_serialization fs4=new File4_serialization();
            fs4.employee_id = 100;
            fs4.employee_name = "Rachana";
            fs4.employee_dept = "Dotnet";

            //IFormatter -> Base class
            //BinaryFormatter -> Derived class
            //BinaryFormatter it has two class -> Serialized , Desrialize
            IFormatter formatter =new BinaryFormatter();

            //stream(abstract class) -> Base
            //Filestream -> Derived class
            Stream s=new FileStream(@"C:\Files_Csharp_Example\TESerialize.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.None);
            //Invoking the Serialize method from BinaryFormatter
            formatter.Serialize(s,fs4);
            s.Close();
            
            //Stream(abstract class) -> Base
            //FileStream -> Derived
            s = new FileStream(@"C:\Files_Csharp_Example\TESerialize.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);

            //formatter.Deserialized(s)->fech the details from TESerialize.txt
            //(File4_serialization)formatter.Deserialize(s) -> typecast the feched details into an object and store in fs4_Deserialize instance
            File4_serialization fs4_Deserialize =(File4_serialization)formatter.Deserialize(s);
            Console.WriteLine(fs4_Deserialize.employee_id);
            Console.WriteLine(fs4_Deserialize.employee_name);
            Console.WriteLine(fs4_Deserialize.employee_dept);
        }
    }
}
