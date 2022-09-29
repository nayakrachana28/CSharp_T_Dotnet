using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    //If we donot mention the access specifier for the class by default it is internal and for properties default access specifier is private
    /// <summary>
    /// Structure 
    /// </summary>
    struct structure1
    {
        public int value;
        public int value2;

        public structure1(int v,int v1)
        {
            //value = 1;
            //value2 = 2;
            value = v;
            value2 = v1;
        }

        public void display()
        {
            Console.WriteLine($"{value}: {value2}");
        }
    }
    internal class pratice1
    {
        public static void Main()
        {
            //for this we get the value without tha params keyword because it is passing the details in single unit
            //int[] total = new int[] {1,2,4,5,6 };
            //Console.WriteLine(param_details(total));
            //int[] total1 = new int[] { 1, 2, 4, 5, 6 };
            //Console.WriteLine(param_details(total1));

            //Here we need to pass keyword because value is passed seperatly
            int total = param_details(1, 2, 3, 4, 5, 6);
            Console.WriteLine(total);
            int toatal2 = param_details(20,30);
            Console.WriteLine(toatal2);

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n");
            //Nullables

            int a = 30;
            Console.WriteLine(a);
            //error
            //int b = null;
            //correct - assiging with ? opertaor
            int? b = null;
            Console.WriteLine(b);
            //assiiging null value with generic class
            Nullable<int> c = null;
            Console.WriteLine("Hello"+c);
            //Null coalesing operator ??
            //This is used when we donot want to return a null value if it contain a null value
            int? name = 1;
            int? age = null;
            int? value;
            //Here we can go with int-int and string-string no like string-int
            value = age ?? name;
            Console.WriteLine(value);

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n");

            //Strucutre
            structure1 structure1 = new structure1(4,5);
            //here it can be a default constructor when we donot give the value it will give 0 then when assigned it will give the value which is assigned
            Console.WriteLine(structure1.value);
            structure1.display();
        }

        public static int param_details(params int[] number)
        {
            int sum = 0;
            foreach(int i in number)
            {
                sum += i;
            }
            return sum;
        }
    }
}
