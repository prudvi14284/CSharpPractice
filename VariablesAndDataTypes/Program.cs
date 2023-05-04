using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a variable for Numerical Data types
            sbyte a = 10;
            byte b = 20;
            short c = 30;
            ushort d = 40;
            int e = 50;
            uint f = 60;
            long g = 70;
            ulong h = 80;
            float i = 90.26F;
            double j = 100.8765;
            decimal k = 110.8343438M;
            Console.WriteLine("NumericaL Data Types: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine();


            //Create a variable for Non-Numerical data types
            Console.WriteLine("Non-NumericaL Data Types: ");
            //Strings
            string s1 = "Prudvi123#@";
            Console.WriteLine("String: ");
            Console.WriteLine(s1);
            Console.WriteLine();

            //Char 
            char ch = 'A';
            Console.WriteLine("Char: ");
            Console.WriteLine(ch);
            Console.WriteLine();

            //bool 
            bool boo1 = true;
            bool boo2 = false;
            Console.WriteLine("Bool: ");
            Console.WriteLine(boo1);
            Console.WriteLine(boo2);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
