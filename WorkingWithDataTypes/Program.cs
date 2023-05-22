using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int
            int t = 10;
            Console.WriteLine(t);
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

            //Strings
            string s1 = "Prudvi";
            string s2 = "Kiran";
            Console.WriteLine("String variable: ");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            //concatination
            Console.WriteLine("Concatination");
            Console.WriteLine(s1 + " and " + s2);
            Console.WriteLine();

            //Formating
            string original = "{0} and {1} are now friends.";
            string format = string.Format(original, s1,s2);
            Console.WriteLine("Formating: " + format);
            Console.WriteLine();

            //String Methods
            Console.WriteLine("String Methods: ");
            int len = s1.Length;
            string upper = s1.ToUpper();
            string lower = s1.ToLower();
            char c = s1[4];
            string substring = s1.Substring(2,3);
            string remove = s2.Remove(2, 3);

            Console.WriteLine("Length: " + len);
            Console.WriteLine("ToUpper: " + upper);
            Console.WriteLine("ToLower: "+ lower);
            Console.WriteLine("GetCharacter: " + c);
            Console.WriteLine("Substring: " + substring);
            Console.WriteLine("Remove: " + remove);

            //Create strings
            string s = "Hyderabad";
            string sd = "abc";
            int ind = 4;
            string s3 = s.Insert(ind, sd);
            Console.WriteLine("Insert: " + s3);

            //create strings
            string s4 = "Hyderabad";
            string s5 = "Hyderabad";
            bool b1 = s4.Equals(s5);
            Console.WriteLine("Equals: " + b1); //Output: True

            string s6 = "hyderabad";
            string s7 = "hyd";
            bool b2 = s6.StartsWith(s7);
            bool b3 = s6.EndsWith(s7);
            bool b4 = s6.Contains(s7);
            Console.WriteLine("Stratswith: " + b2); //Output: True
            Console.WriteLine("Endswith " + b3); //Output: False
            Console.WriteLine("Contains: " + b4); //Output: True

            string s8 = "hyderabad";
            string s9 = "a";
            int ind1 = s8.IndexOf(s9);
            int ind2 = s8.LastIndexOf(s9);
            Console.WriteLine("IndexOf: " + ind1); //5
            Console.WriteLine("IndexOf: " + ind2); //7
            Console.WriteLine();

            //create strings
            string s10 = "Apple Smart Phones";
            string app = "Apple";
            string sam = "Samsung";
            string s11 = s10.Replace(app, sam);
            Console.WriteLine("Replace: " + s11); //Output: Samsung Smart Phones
            Console.WriteLine();

            //Split
            //create string and character
            string a1 = "Hyderabad is one of the cities in India";
            char a2 = ' ';
            //convert the "string" into "string array" at each occurrence of " " (space)
            string[] a3 = a1.Split(a2);

            Console.WriteLine("Split: ");
            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine(a3[i]);
            }
            Console.WriteLine();

            //Reverse
            string c1 = "hyderabad";
            string c2 = "";
            //read each character using for loop and append it to a new string
            for (int i = c1.Length - 1; i >= 0; i--)
            {
                c2 = c2 + c1[i];
            }
            Console.WriteLine("Reverse: " + c2);

            Console.WriteLine();


            //Date and Time
            DateTime dt = DateTime.Now;
            Console.WriteLine("Date Time: ");
            Console.WriteLine("Day :" + dt.Day);
            Console.WriteLine("Year :" + dt.Year);
            Console.WriteLine("Hour :" + dt.Hour);
            Console.WriteLine("Minute :" + dt.Minute);
            Console.WriteLine("Second :" + dt.Second);
            Console.WriteLine("Millisecond :" + dt.Millisecond);
            Console.WriteLine("Day of Week :" + dt.DayOfWeek);
            Console.WriteLine("Day of Year : " + dt.DayOfYear);
            Console.WriteLine("Time of Day :"+ dt.TimeOfDay);

            TimeSpan aMonth = new TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAMonth = dt.Add(aMonth);
            DateTime aDayBeforeAMonth = dt.Subtract(aMonth);

            Console.WriteLine("Current date and time: " + dt);
            Console.WriteLine("Current Month time span: " + aMonth);
            Console.WriteLine("ADayAfterMonth: " + aDayAfterAMonth);
            Console.WriteLine("ADayBeforeMonth" + aDayBeforeAMonth);

            string str1 = dt.ToShortDateString();
            Console.WriteLine("Short Date: " + str1);

            string str2 = dt.ToLongDateString();
            Console.WriteLine("Long Date: " + str2);

            string str3 = dt.ToShortTimeString();
            Console.WriteLine("Long Date: " + str3);

            string str4 = dt.ToLongTimeString();
            Console.WriteLine("Long Date: " + str4);

            // Add Years and Days
            Console.WriteLine(dt.AddYears(3));
            Console.WriteLine(dt.AddDays(12));
            // Add Hours, Minutes, Seconds, Milliseconds, and Ticks
            Console.WriteLine(dt.AddHours(4.25));
            Console.WriteLine(dt.AddMinutes(15));
            Console.WriteLine(dt.AddSeconds(45));
            Console.WriteLine(dt.AddMilliseconds(200));

            Console.ReadKey();
        }
    }
}
