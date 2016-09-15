using System;

namespace ConsoleApplication
{
    public class Program
    {
        // ref
        // The ref keyword causes an argument to be passed by reference, not by value.
        // If the ref keyword is omitted a new int would be declared inside the parameter.
        // The ref keyword takes a hold of the reference, and adjusts the reference accordingly.

        // out
        // The Out keyword allows you to pass a referenced parameter without a value. However, the 
        // value MUST be set to a value inside the method.

        // Both the method definition and the calling method must explicitly use the ref or out keyword  

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
