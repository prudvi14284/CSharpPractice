using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    [Serializable] //Serialization attribute
    public class Student
    {
        public int Id;
        public string Name;

        public static void Main(string[] args)
        {
            //Create an Object
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Prudvi";

            //Create the file stream
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("D:\\Example.txt", FileMode.Create, FileAccess.Write);

            //Serialize the object
            formatter.Serialize(stream, s1);
            stream.Close();

            //Create the file stream
            stream = new FileStream("D:\\Example.txt", FileMode.Open, FileAccess.Read);

            //Deserialize the object
            Student s2 = (Student)formatter.Deserialize(stream);

            Console.WriteLine(s2.Id);
            Console.WriteLine(s2.Name);

            Console.ReadKey();
        }
    }
}
