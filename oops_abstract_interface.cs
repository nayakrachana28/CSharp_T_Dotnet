using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Interface
    /// Interface Name should start with capital I followed by name
    /// </summary>
    interface IName
    {
        /// <summary>
        /// Abstract properties
        /// For the security propose the interface is used where as the abstract keyword is mainly used when ever we require the overriding concept
        /// In Interface we can use the abstract method and properties but cannot use the abstract method.
        /// In C# Multiple inheritance concept is not supported but with the help of interface we can use the Multiple interface concepts
        /// </summary>
 
        string Name { get; set; }

      

        /// <summary>
        /// Abstract method
        /// </summary>
        /// Here we can Use public Access Modifier also
        void nameDetails();

        void Message();

       
    }

    /// <summary>
    /// Another Interface for the Multiple inheritance
    /// </summary>
    interface Iage
    {
        int age { get; set; }

        /// <summary>
        /// Abstract Method
        /// Here We can use public Access specifier
        /// </summary>
        void ageDetails();

        void Message();

    }

    /// <summary>
    /// Child class that implements(no using inheritance) the parent interface
    /// </summary>
    public class child: IName , Iage
    {
        /// <summary>
        /// This is implemented from IName Interface
        /// </summary>
        public string Name { get; set; }

        public void nameDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine("Hello and Welcome!!!!");
        }

        /// <summary>
        /// Message is taken from IName Interface 
        /// This is used When two interface has a same method name
        /// </summary>

         void IName.Message()
        {
            Console.WriteLine("This gives Name");
        }

        /// <summary>
        /// This is Implemented from IAge interface
        /// </summary>
        public int age { get; set; }
        public void ageDetails()
        {
            Console.WriteLine(age);
        }
        /// <summary>
        /// Message is taken from IAge Interface 
        /// This is used When two interface has a same method name
        /// </summary>
        void Iage.Message()
        {

            Console.WriteLine("This gives Age");
        }
    }
   
    /// <summary>
    /// This is the Destructor -Where the Working of Dispose() method is given
    /// This is explicit method
    /// </summary>
    public class destuctor1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("The Memory is Cleaned");
        }
    }
    internal class oops_abstract_interface
    {
        public static void Main()
        {
            //Base -> derived class
            IName na=new child();
            na.Name = "Rachana";
            na.nameDetails();
            Iage a=new child();
            a.age = 20;
            a.ageDetails();
            //When there is same method in a class
            na.Message();
            a.Message();
            destuctor1 destuctor1 = new destuctor1();
            destuctor1.Dispose();

        }
    }
}
