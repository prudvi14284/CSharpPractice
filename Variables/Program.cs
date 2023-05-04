using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a variable
            int x;
            //set value into the variable
            x = 54;
            Console.WriteLine();
            Console.WriteLine("Variables: ");
            Console.WriteLine(x);

            long z;
            z = 57635;
            Console.WriteLine(z);

            float y;
            y = 35.33F;
            Console.WriteLine(y);

            double db = 65.5353;
            Console.WriteLine(db);

            decimal de = 101.27632742M;
            Console.WriteLine(de);

            Console.ReadKey();
        }
    }
}
