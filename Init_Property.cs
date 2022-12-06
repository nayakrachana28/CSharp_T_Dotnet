using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Training_CSharp
{
    class Member
    {
        //Using init it is not mutable by third person
        public int ID { get; init; }
        public string Name { get; init; }
        public string Address { get; init; }
        
    }
    //Record Type-> Immutable
    internal class Init_Property
    {
        public static void Main()
        {
            Member member = new Member
            {
                ID = 1,
                Name = "Rachana",
                //Address = "Ankola"
                
            };
            //member.Name = "Rachana";
            //member.Address = "Ankola";
            Console.WriteLine(member.ID);
            Console.WriteLine(member.Name);
            Console.WriteLine(member.Address);

        }
    }
}
