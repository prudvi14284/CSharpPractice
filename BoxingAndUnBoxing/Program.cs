using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int a = 10; //Value type
            Object b; //Reference type

            b = a;
            Console.WriteLine(b);

            //Unboxing
            Object c = 100; //Reference type
            int d; //Value type

            d = (int)c;

            Console.WriteLine(d);
        }
    }
}
