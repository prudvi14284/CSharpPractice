using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum GenderEnumeration
    {
        Male, Female
    }

    //create a class Person
    class Person
    {
        public string PersonName;
        public GenderEnumeration Gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p; //Referance variable
            p = new Person(); //Object of peron
            p.PersonName = "Prudvi";
            p.Gender = GenderEnumeration.Male;
            Console.WriteLine(p.PersonName);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }
}
