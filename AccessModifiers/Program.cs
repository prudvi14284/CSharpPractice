using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Same class
    class Class1
    {
        private int a; //private member
        protected int b; //protected member
        internal int c; //internal member
        protected internal int d; //protected internal member
        public int e; //public member

        public void Method1()
        {
            a = 10; //private member 
            b = 20; //protected member 
            c = 30; //internal member 
            d = 40; //protected internal member 
            e = 50; //public member 
        }
    }

    //Child class in the same project
    class Class2 : Class1
    {
        public void Method()
        {
            b = 20; //protected member 
            c = 30; //internal member 
            d = 40; //protected internal member 
            e = 50; //public member 
        }
    }

    //other class in the same project
    class Class3
    {
        public void Method3()
        {
            Class1 c1 = new Class1();
            c1.c = 30; //internal member 
            c1.d = 40; //protected internal member 
            c1.e = 50; //public member 
        }
    }

    //other class in the same project
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.c = 30; //internal member 
            c1.d = 40; //protected internal member 
            c1.e = 50; //public member 
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
