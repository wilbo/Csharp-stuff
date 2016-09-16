using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Vector v1 = new Vector(5,3);
            Vector v2 = new Vector(2,6);
            Vector v3;

            v3 = v1 + v2;

            Console.WriteLine(v3);
        }
    }
}
