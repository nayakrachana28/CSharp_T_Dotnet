using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Inheritance-Single, Multilevel,Hierarchical, Hybrid inheritance
    /// </summary>
    public class singleinheri
    {
        public class parent
        {
            protected string name;
            public int id;
             public void d()
            {
                Console.WriteLine("Parent");
            }
        }

        public class child : parent
        {
            public int eid;
            public void d1()
            {
                //The name is protected and it can be accssed inside the child class but not inside the parent class
                name = "Ankur";
                d();
                Console.WriteLine("Child");
                Console.WriteLine($"{eid} : {name}: {id}");
            }
        }
    }

    /// <summary>
    /// Multi-Level
    /// </summary>
    public class multilevelinheri
    {
        public class parent
        {
            public int salary;
            public int eid;

            public void p()
            {
                Console.WriteLine("This is a Parent");
            }
        }
        public class child : parent
        {
            protected string name;
            public void c()
            {
                Console.WriteLine("This is a Child");
            }
        }
        public class childschild:child
        {
            public void cc()
            {
                //cannot acces ouside the method it has to access inside the method itself
                name = "Rachana";
                eid = 1;
                p();
                c();
                Console.WriteLine("This is a Childs Child");
            }
            
      
        }
    }
    internal class oops_inheritance
    {
        public static void Main()
        {

            //Single Inheritance
            singleinheri singleinheri = new singleinheri();
            singleinheri.child ch = new singleinheri.child();
            ch.eid = 1;
            //Here I cannot access the name as it is a protected one.
            //ch.name = "Ankur";
            ch.id = 123;
            ch.d1();

            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");

            //Multi-level Inheritance
            multilevelinheri multilevelinheri = new multilevelinheri();
            multilevelinheri.childschild csc=new multilevelinheri.childschild();
            csc.cc();

        }
    }
}
