using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Class1
    {
        ~Class1()
        {
           Console.WriteLine("Display Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();

            c1 = null;

            //Delete all the objects
            GC.Collect();

            Console.WriteLine("Garbage Collection done");

            Console.ReadKey();
        }
    }






    //class Base
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Display Method");
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {           
    //        Console.WriteLine("TotalMemory:" + GC.GetTotalMemory(false));
    //        Base b = new Base();
    //        Console.WriteLine("BaseGeneration is :" + GC.GetGeneration(b));
    //        Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
    //        Console.ReadKey();                      
    //    }
    //}
}
