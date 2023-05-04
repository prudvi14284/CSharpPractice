using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create strings
            string s1, s2, s3, s4;
            s1 = "Hello "; //string object 1
            s2 = "how "; //string object 2
            s3 = "are "; //string object 3
            s4 = "you"; //string object 4
            
            //create reference variable
            StringBuilder result;

            //create object for StringBuilder class
            result = new StringBuilder();

            //append strings to the stringbuilder
            result.Append(s1);
            result.Append(s2);
            result.Append(s3);
            result.Append(s4);
            Console.WriteLine(result.ToString()); //Output: Hello how are you
            Console.ReadKey();

            
            
            
            
            ////StringBuilder
            //StringBuilder sb1 = new StringBuilder("Hello World!");

            //Console.WriteLine("String Builder: ");
            //for (int i = 0; i < sb1.Length; i++)
            //{
            //    Console.Write(sb1[i]);
            //}
            //Console.WriteLine();

            ////Retrieve string to StringBuilder
            //StringBuilder sb2 = new StringBuilder("This is a string builder");
            //var s = sb2.ToString();
            //Console.WriteLine(s); //returns "This is a string builder"
            //Console.WriteLine();

            ////Add/Append String to StringBuilder
            //StringBuilder sb3 = new StringBuilder("Hello World ");
            //sb3.Append("C# Program ");
            //sb3.AppendLine("Microsoft");
            //sb3.AppendLine("Other Programs");
            //Console.WriteLine(sb3);

            ////Append Formated String to StringBuilder
            //StringBuilder sb4 = new StringBuilder("Your total amount is ");
            //sb4.AppendFormat("{0:C} ", 25);
            //Console.WriteLine(sb4);
            //Console.WriteLine();

            ////Insert String into StringBuilder
            //StringBuilder sb5 = new StringBuilder("Hello World!");
            //sb5.Insert(5, " C#");
            //Console.WriteLine("Insert: " + sb5); //output: Hello C# World!
            //Console.WriteLine();

            ////Remove String in StringBuilder
            //StringBuilder sb = new StringBuilder("Hello World!", 50);
            //sb.Remove(6, 6);
            //Console.WriteLine("Remove: " + sb); //output: Hello
            //Console.WriteLine();

            ////Replace String in StringBuilder
            //StringBuilder sb7 = new StringBuilder("Hello World!");
            //sb7.Replace("World", "C#");
            //Console.WriteLine("Replace: " + sb7);//output: Hello C#!
            //Console.ReadKey();
        }
    }
}
