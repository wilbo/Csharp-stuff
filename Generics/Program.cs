using System;

namespace ConsoleApplication
{

    // Generics
    // https://msdn.microsoft.com/nl-nl/library/512aeb7t.aspx

    public class Program
    {
        public static void Main(string[] args)
        {
            // printing array's
            char[] charArray = new char[] { 'a', 'b', 'c', 'd' };
            double[] doubleArray = new double[] {12.22, 43.54, 34.32, 34.78};    
       
            PrintArray(charArray);
            PrintArray(doubleArray);

            // swapping 
            int a = 1, b = 2;
            char c = 'a', d = 'b';

            Swap(ref a, ref b);
            Swap(ref c, ref d);

            Console.WriteLine(a + ", " + b);
            Console.WriteLine(c + ", " + d);
        }

        // generic, using "T" for type
        public static void PrintArray <T> (T[] inputArray)
        {
            foreach (T element in inputArray) 
                Console.Write(element + ", ");

            Console.WriteLine();    
        }

        // swap, generic, again using "T" for type
        public static void Swap<T>(ref T y, ref T z)
        {
            T temp = y;
            y = z;
            z = temp;
        }

        // This example uses a constraint: 'where T : IComparable<T>'
        // to check if te given parameter values are comparable
        // https://msdn.microsoft.com/nl-nl/library/bb384067.aspx 
        public static T Maximum<T> (T first, T second, T third) 
            where T : IComparable<T>
        {
            T max = first;
            if (second.CompareTo(first) > 0)
                max = second;
            if (third.CompareTo(max) > 0)
                max = third;

            return max;
        }

    }

    // a class with a generic type (Example)
    class MyCollection<T> 
    {

        private T[] array = new T[10];
        private int cursor = 0;

        public void Add(T n) 
        {
            if (cursor < 10)
                array[cursor++] = n;
        }
    }

}