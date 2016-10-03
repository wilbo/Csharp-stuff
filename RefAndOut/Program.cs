using System;

namespace ConsoleApplication
{

    // ref
    // https://msdn.microsoft.com/en-us/library/14akc2c7.aspx

    // out
    // https://msdn.microsoft.com/en-us/library/t3c3bfhx.aspx

    public class Program
    {
        public static void Modify(out string a, ref int b)
        {
            a = "Ty Burrel";
            b += 25;
        }

        public static void Main(string[] args)
        {
            
            string name;
            int age = 25;

            Modify(out name, ref age);
            Console.WriteLine("name: {0}, age: {1}", name, age);
        }
    }
}
