using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Generic class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Generic<T>
    {
        //Generic Variable
        public T generic_value;

        /// <summary>
        /// Generic Constructor with one parameter
        /// </summary>
        /// <param name="value"></param>
        public Generic(T value)
        {
            this.generic_value = value;
        }

        /// <summary>
        /// Generic Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Genericparameter"></param>
        public void Generic_method<T>(T Genericparameter)
        {
            Console.WriteLine($"This is the parameter : {Genericparameter} and this is the variable value : {generic_value}");
        }

        /// <summary>
        /// Generic property
        /// </summary>
        public T Generic_property { get; set; }
    }
    /// <summary>
    /// To use the type specific data we go for the concept of generic
    /// Entier class can generic, method, properites, variable,constructor can be generic
    /// 
    /// </summary>
    internal class Generics1
    {
        public static void stage1()
        {
            bool result = Areaequal(123, "ABC");
            if(result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        /// <summary>
        /// Object -> Reference datatype -> not type specific -> Example : First parameter can be int and second parameter can be string
        /// Object can have only datatype
        /// Since object is the reference datatype the value passed will be value ype and then converted it into a reference type.
        /// Here we can implement that only int or string
        /// This is BOXING/UNBOXING Technique -> poor performance
        /// To overecome this we go for overloading
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool Areaequal(object value1,object value2)
        {
            return value1 == value2;
        }
        /// <summary>
        /// Overloding method
        /// In this for each datatype there should be sperate method that's way the program become long and complicated, this lead to poor performance
        /// Code to repeted many time -> to overcome this we use the concept of generics
        /// </summary>
        public static void stage2()
        {
            bool result=Areaequal_int(1, 2);
            bool result1 = Areaequal_string("ABC", "ABC");
            if (result1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
        public static bool Areaequal_int(int value1,int value2)
        {
            return (value1 == value2);
        }
        public static bool Areaequal_string(string value1, string value2)
        {
            return (value1 == value2);
        }
        public static void Main()
        {
            stage1();
            Console.WriteLine("--------------------------------------------");
            stage2();
            Console.WriteLine("--------------------------------------------");
            //Generic
            stage3();
            Console.WriteLine("--------------------------------------------");
            //Calling the Instance of the generic class
            //Training_CSharp.Generic<int> g1 = new Training_CSharp.Generic<int>(100);
            Generic<int> generic1 = new Generic<int>(100);
            generic1.Generic_method(5000);
            generic1.Generic_property = 24;
            Console.WriteLine($"Age : {generic1.Generic_property}");
            Console.WriteLine("--------------------------------------------");
            //Calling instance with string
            Generic<string> generic2 = new Generic<string>("Rachana");
            generic2.Generic_method("5000");
            generic2.Generic_property = "29";
            Console.WriteLine($"Age : {generic2.Generic_property}");
            Console.WriteLine("--------------------------------------------");


        }
        /// <summary>
        /// Generics <>
        /// </summary>
        public static void stage3()
        {
            bool result = areaequal_generic<int>(10,10);
            bool result1 = areaequal_generic<string>("ABC", "BDC");
            bool result2 = areaequal_generic<int, string>(10, "10");
            if (result2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


        }
        public static bool areaequal_generic<T>(T value1,T value2)//Same datatype 
        {
            return value1.Equals(value2);
        }
        public static bool areaequal_generic<T,T1>(T value1, T1 value2)//Different datatype 
        {
            return value1.Equals(value2);
        }
    }
}
