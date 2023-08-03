using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;

            //Value parameters
            Valuethod(x);
            Console.WriteLine("Value Parameter: " + x); //Output : 20

            //Refereance parameters
            ReferanceMethod(ref x);
            Console.WriteLine("Reference Parameres: " + x); //Output : 40

            //Output parameters
            int totalSum, totalProduct;
            OutPutMethod(4, 8, out totalSum, out totalProduct);

            Console.WriteLine("totalSum: " + totalSum); //Output : 12
            Console.WriteLine("totalProduct: " + totalProduct); //Output : 32

            //Params Array Parameters
            int[] EvenNumbers = new int[3];// Array
            EvenNumbers[0] = 10;
            EvenNumbers[1] = 20;
            EvenNumbers[2] = 30;

            ParamsMethod(EvenNumbers);
        }

        //Value parameters
        public static void Valuethod(int x)
        {
            x = 30;
        }

        //Referance parameters
        public static void ReferanceMethod(ref int x)
        {
            x = 40;
        }

        //Otput parameters
        public static void OutPutMethod(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        //Perameters Array(Params)
        public static void ParamsMethod(params int[] ListEvenNumbers)
        {
            Console.WriteLine("Params: ");
            foreach (int i in ListEvenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
