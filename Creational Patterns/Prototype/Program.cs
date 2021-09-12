using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.age = 42;
            p1.birthDate = Convert.ToDateTime("1997-01-01");
            p1.name = "Jack Daniels";
            p1.idInfo = new IdInfo(666);

            //Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();
            //Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();

            //Display values of p1, p2 and p3
            Console.WriteLine("\nOriginal values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1, p2, p3
            p1.age = 32;
            p1.birthDate = Convert.ToDateTime("1900-01-01");
            p1.name = "Frank";
            p1.idInfo.idNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yyyy}",
                         p.name, p.age, p.birthDate);
            Console.WriteLine("      ID#: {0:d}", p.idInfo.idNumber);
        }
    }
}
