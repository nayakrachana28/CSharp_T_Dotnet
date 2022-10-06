using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Task18_Collections
    {
        /// <summary>
        /// Dictionary in Collections
        /// </summary>
        public static void dictionary_concept()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Rachana");
            dictionary.Add(2, "Vinay");
            dictionary.Add(3, "Ruchitha");
            dictionary.Add(4, "Ananya");
            dictionary.Add(5, "Rakesh");
            dictionary.Add(6, "Rajkumar");
            Console.WriteLine("Elements inside Dictionary ");
            foreach(var d in dictionary)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Keys inside Dictionary ");
            var key = new List<int>(dictionary.Keys);
            foreach (var k in dictionary.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Values inside Dictionary ");
            var value = new List<string>(dictionary.Values);
            foreach (var v in value)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("----------------------------------------------");
        }
        /// <summary>
        /// Hashtable in Collection
        /// Hashtable is not a Generic type collection
        /// It is from sysyem.collection
        /// Not type speciic
        /// key-value pair
        /// </summary>
        public static void hashtable_concept()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Dotnet");
            ht.Add(2, "Java");
            ht.Add(3, "Python");
            ht.Add(4, "C");
            ht.Add(5, "Database");
            //Unlike the other if we normal loop it will not loop
            //Interface to loop the elemets
            //Using ICollection Interface(loop)
            ICollection key= ht.Keys;
            foreach (var k in key)
            {
                Console.WriteLine(ht[k]);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[10]);
        }
        public static void Main()
        {
            dictionary_concept();
            hashtable_concept();
        }
    }
}
