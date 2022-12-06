using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class pratice3
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            //Array is the reference datatype we must use new keyword to create an instance of the array
            int[] at =new int[10];
            string[] a = { "abc", "bca", "cab" };
            foreach(string c in a)
            {
                Console.WriteLine(c);
                //startswith()
                if (c.StartsWith('b')){
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("--------------------------");
            //Generate random number
            //A small popup that gives the hint is the intellisence
            Random rnd = new Random();
            int rand = rnd.Next(1, 10);
            Console.WriteLine(rand);
            Console.WriteLine("--------------------------");
            OrderIdGenerate();

        }

        public static void OrderIdGenerate()
        {
            Random random = new Random();
            string[] orderIDs = new string[5];
            // Loop through each blank orderID
            for (int i = 0; i < orderIDs.Length; i++)
            {
                // Get a random value that equates to ASCII letters A through E
                int prefixValue = random.Next(65, 70);
                // Convert the random value into a char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, padd with zeroes
                string suffix = random.Next(1, 1000).ToString("000");
                // Combine the prefix and suffix together, then assign to current OrderID
                orderIDs[i] = prefix + suffix;
            }
            // Print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }
    }
}
