using System;

namespace ConsoleApplication
{

    // Accessors
    // https://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx

    public class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "James";
            p.age = 34;

            Console.WriteLine(p);
        }
    }
}
