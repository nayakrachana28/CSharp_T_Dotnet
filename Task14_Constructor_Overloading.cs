using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Class with constructor overloading
    /// Constructor Overloading - same constructor function name with diffferent parameter
    /// </summary>
    internal class Task14_Constructor_Overloading
    {
        private int id, age;
        private string name, designation;
        private float efficency, salary;

        /// <summary>
        /// First Constructor
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="eage"></param>
        public Task14_Constructor_Overloading(int eid,int eage)
        {
            id = eid;
            age = eage; 
        }
        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="esalary"></param>
        /// <param name="eefficency"></param>
        public Task14_Constructor_Overloading(float esalary, float eefficency)
        {
            salary = esalary;
            efficency = eefficency;
        }
        /// <summary>
        /// Third constructor
        /// </summary>
        /// <param name="ename"></param>
        /// <param name="edesignation"></param>

        public Task14_Constructor_Overloading(string ename, string edesignation)
        {
            name = ename;
            designation = edesignation;
        }

        public void interger_overload()
        {
            Console.WriteLine($"Employee Details = Employee ID : {id} , Employee Age: {age}");

        }
        public void interger_overload1()
        {
            Console.WriteLine($"Employee Details = Employee Name : {name} , Employee Designation : {designation}");
        }
        public void interger_overload2()
        { 
            Console.WriteLine($"Employee Salaray : {salary} , Employee Effiency : {efficency}");
        }

        public static void Main()
        {
            //User entering the Details
            Console.WriteLine("Enter the Employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Age");
            int empage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter the Employee Designation");
            string empdesignation = Console.ReadLine();
            Console.WriteLine("Enter the Employee Salary");
            float empsalary = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Effiency in 100.00%");
            float empeffiency = float.Parse(Console.ReadLine());
            //Creating an instance
            Task14_Constructor_Overloading constructor_overloading = new Task14_Constructor_Overloading(empid, empage);
            Task14_Constructor_Overloading constructor_overloading1 = new Task14_Constructor_Overloading(empname, empdesignation);
            Task14_Constructor_Overloading constructor_overloading2 = new Task14_Constructor_Overloading(empsalary, empeffiency);
            constructor_overloading.interger_overload();
            constructor_overloading1.interger_overload1();
            constructor_overloading2.interger_overload2();



        }
    }
}
