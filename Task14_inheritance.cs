using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Inheritance- Hierarchical inheritance
    /// </summary>
    internal class Bonus
    {
        protected int bonus;

        /// <summary>
        /// Parent class
        /// </summary>
        protected void readbonus()
        {
            Console.WriteLine("Enter the Bonus");
            bonus =Convert.ToInt32(Console.ReadLine());
        }
    }
    /// <summary>
    /// Derived Class
    /// </summary>
    internal class staff : Bonus
    {
        private int salary;
        public void staff_bonus()
        {
            Console.WriteLine("Calculating the Bonus for Staff");
            readbonus();
            Console.WriteLine("Enter the Salary for Staff");
            salary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Bonus for Staff is 3 times : {3 * bonus}");
            Console.WriteLine($"Total Salary with 3 times the Bonus is given : {salary+(3*bonus)}");
        }
    }
    /// <summary>
    /// Derived Class
    /// </summary>
    internal class nonstaff : Bonus
    {
        private int salary;
        public void non_staff_bonus()
        {
            Console.WriteLine("Calculating the Bonus for Non-Staff");
            readbonus();
            Console.WriteLine("Enter the Salary for Non-Staff");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Bonus for Non-staff is 2 times : {2*bonus}");
            Console.WriteLine($"Total Salary with 2 times the Bonus is given : {salary + (2 * bonus)}");
        }
    }

    internal class Task14_inheritance
    {
        public static void Main()
        {
            staff s=new staff();
            nonstaff ns=new nonstaff();
            Console.WriteLine("Enter 1.Staff 2.Non-staff");
            int enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1: s.staff_bonus(); break;
                case 2: ns.non_staff_bonus(); break;
                default: Console.WriteLine("Enter the correct option");break;
            }
            
        }
    }
}
