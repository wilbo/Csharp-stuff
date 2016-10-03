using System;

namespace ConsoleApplication
{

    // Overloadable Operators
    // https://msdn.microsoft.com/nl-nl/library/8edha89s.aspx

    public class Program
    {
        public static void Main(string[] args)
        {
            
            Vector v1 = new Vector(5,3);
            Vector v2 = new Vector(2,6);
            Vector v3;

            // apply operator overloading
            v3 = v1 + v2;

            // show results
            Console.WriteLine(v3);
        }
    }
}
