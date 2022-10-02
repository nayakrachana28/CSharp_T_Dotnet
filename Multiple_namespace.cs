using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In the program it can have any Number of Namespace
//First Namespace with the Same method as the Second Namespace
namespace first_namespace
{
    internal class first_namespace_class
    {
        public void method1()
        {
            Console.WriteLine("First Namespace without static method");
        }
    }
}
//Second Namespace with the Same method as the First Namespace
namespace second_namespace
{
    internal class second_namespace_class
    {
        public static void method1()
        {
            Console.WriteLine("Second Namespace with static method");
        }
    }
}

//Nested Namespace
namespace nestedNamespace
{
    namespace nested1_Namespace
    {
        class third_Namespace
        {
            public static void method1()
            {
                Console.WriteLine("Third Namespace : Nested");
            }
        }
    }
}


//Main Method to call the Namespace
namespace Training_CSharp
{
    internal class Multiple_namespace
    {
        public static void Main()
        {
            //Calling Namespace without Static Method
            first_namespace.first_namespace_class s = new first_namespace.first_namespace_class();
            s.method1();
            //Calling Namespace with Static method
            second_namespace.second_namespace_class.method1();
            //Nested Namespace
            nestedNamespace.nested1_Namespace.third_Namespace.method1();
        }
    }
}
