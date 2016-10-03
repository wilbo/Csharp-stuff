using System;

namespace ConsoleApplication
{
    public class Program
    {

        // Generics allow you to define type-safe data structures, without committing to actual data types.

        public static void Main(string[] args)
        {
            // array's
            char[] charArray = new char[] { 'a', 'b', 'c', 'd' };
            double[] doubleArray = new double[] {12.22, 43.54, 34.32, 34.78};           

            PrintArray(charArray);
            PrintArray(doubleArray);

            // int's swap
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);
            Console.WriteLine(a + ", " + b);
        }

        // generic, using "T" for type
        public static void PrintArray <T> (T[] inputArray)
        {
            foreach (T element in inputArray) {
                Console.WriteLine(element + " ");
            }
        }

        // swap, generic, again using "T" for type
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    // a class with a generic type (Example)
    class MyCollection<T> {

        private T[] array = new T[10];
        private int cursor = 0;

        public void Add(T n) {
            if (cursor < 10)
                array[cursor++] = n;
        }
    }

}