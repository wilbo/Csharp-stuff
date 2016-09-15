using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Henkie";
            p.age = 34;

            Console.WriteLine(p);

        }
    }
}
