using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Creating a Delegate
    /// Delegate- Which holds the reference of the Method-This Usually occurred at runtime
    /// The Delegate is a type of the Class - This is present in the using.system namespace itself.
    /// Two Types of Delegate That is 1) Single-Cast 2) Multi-Cast
    /// Single-Cast=Can refer one method at a time
    /// Multi-Cast=Can refer more than one method at a time
    /// </summary>
    /// <param name="studentID"></param>
    /// <param name="studentName"></param>
    public delegate void studentDeligate(int studentID,string studentName);
    /// <summary>
    /// Multi-Cast Deligate
    /// </summary>
    /// <param name="studentID"></param>
    /// <param name="studentName"></param>
    public delegate void studentDeligate1(int studentID, string studentName);

    /// <summary>
    /// Creating a Class with the Method of the same signature as that of the Delegates
    /// </summary>
    public class studentDetails
    {
        /// <summary>
        /// The Signature of the Method showed be same as that of the Delegates
        /// Like the Same Return Type, Same Parameter (Then only the delegate can hold the reference of the method)
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="studentName"></param>
        public void studentCS(int studentID,string studentName)
        {
            Console.WriteLine($"CS Department= {studentID} : {studentName}");
        }
        public void studentEC(int studentID, string studentName)
        {
            Console.WriteLine($"EC Department= {studentID} : {studentName}");
        }
    }

    /// <summary>
    /// Passing the Delegate as parameter to the Method
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public delegate void passdelegateasparameter(int a,int b);

    /// <summary>
    /// Creating a class to refer the method by the delegate
    /// </summary>
    public class calulation
    {
        public void square(int a, int b)
        {
            Console.WriteLine($"{a*a} : {b*b}");
        }
        public void cube(int a, int b)
        {
            Console.WriteLine($"{a * a *a} : {b*b*b}");
        }
    }
    internal class Delegates1
    {
        public static void Main()
        {
            //Access the Method through the Delegate
            //Create a Instance of the Class
            studentDetails studentDetails = new studentDetails();
            //Create a Instance of the Delegate
            //studentDeligate std; OR
            //Single-Cast Delegate = Where we can pass single method to the Delegate at a time
            studentDeligate std = studentDetails.studentCS;
            std(100, "Amar");
            std = studentDetails.studentEC;
            std(200, "Karuna");
            Console.WriteLine("-----------------------------------------------");

            //Multi-Cast Delegate
            studentDeligate1 std1 = studentDetails.studentCS;
            //To add More than one method
            std1+=studentDetails.studentEC;
            //We can pass invoke method also 
            //std1.Invoke(2001, "Arjun");
            //Without the invoke method
            std1(2001, "Arjun");
            //To remove the Method from the Delegate
            std1 -=studentDetails.studentCS;
            std1(345, "Anusha");

            Console.WriteLine("-----------------------------------------------");
            //Passing the Delegate as the parameter
            calulation c=new calulation();
            value(c.square, 3, 4);
            value(c.cube, 3, 4);

        }
        /// <summary>
        /// Passing the Delegate as the Parameter and the value directly
        /// </summary>
        /// <param name="del"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>

        public static void value(passdelegateasparameter del,int f, int g)
        {
            //Here we can the different variable name but the datatype should be same
            del(f, g);
        }
    }
}
