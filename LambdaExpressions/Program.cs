using System;

namespace ConsoleApplication
{

    // Lambda Expressions
    // https://msdn.microsoft.com/en-us/library/bb397687.aspx
    
    class Program
    {

        //
        // default delegate

        // delegate int Convert(int i);
        // static void Main(string[] args)
        // {
        //     Convert convert = MySubtractTwo;
        //     Console.WriteLine(convert(4));
        // }
        // private static int MySubtractTwo(int i) { return i - 2; }

        //
        // anonymous delegate

        // delegate int Convert(int i);
        // static void Main(string[] args)
        // {        
        //     Convert convert = delegate (int i) { return i - 2; };
        //     Console.WriteLine(convert(4));
        // }

        //
        // lambda expression

        delegate int Convert(int i);
        static void Main(string[] args)
        {
            Convert convert = x => x - 2;
            Console.WriteLine(convert(4));
        }

        //
        // lambda expression with Func

        // static void Main(string[] args)
        // {
        //     Func<int, int> convert = x => x - 2;
        //     Console.WriteLine(convert(4));
        // }

    }
}
