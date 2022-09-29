using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Abstract Class which contain the Variable, propeties and methods
    /// It can have a abstract method and Non-abstract Metod
    /// </summary>
    public abstract class salary
    {
        //abstract variable
        protected int salary1;
        public int bonus;
        public int value1;

        /// <summary>
        /// The abstract method showed not contain the implementation. The implementation should be in the derived class or the inherited class
        /// </summary>
        public abstract void GetSalary();
        public abstract void GetBonus();

        /// <summary>
        /// non-abstract method -it can be decalred and have propeties
        /// </summary>
        public void setsalary()
        {
            salary1 = salary1 + ((salary1 * bonus) / 100);
            Console.WriteLine(salary1);
        }
    }

    /// <summary>
    /// We cannot access the abstract class directly by the other or Main class.
    /// To access the abstract class we use the inheritance method.
    /// when ever inherited the abstract method should be overrriden.
    /// salary_child implements the properties and methods of the salary
    /// </summary>
    public class salary_child : salary
    {
        /// <summary>
        /// Overriding the abstract class
        /// overriding- when a subclass or child class has same method as the parent class
        /// In abstract class there only calling tha abstract method
        /// In Interface the properties should be called
        /// </summary>
     
        public override void GetSalary()
        {
            salary1 = 20000;
        }
        public override void GetBonus()
        {
            bonus = 5;

        }

    }
    public class destuctor12 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("The Memory is Cleaned");
        }
    }
    internal class oops_abstraction
    {
        public static void Main()
        {
            salary sc;
            sc = new salary_child();
            //salary_child sc = new salary_child();
            sc.GetSalary();
            sc.GetBonus();
            sc.setsalary();
            //here we cannot access the salary as it is protected
            //sc.salary1;
            //we can asign the value to  bonus after overriding and get the salary
            sc.bonus=3;
            sc.setsalary();
            destuctor12 destuctor12 = new destuctor12();
            destuctor12.Dispose();

        }
    }
}
