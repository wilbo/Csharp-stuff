using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create integer array
            int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            // display original values
            Console.Write("Original array:");
            foreach ( var element in values)
                Console.Write(" {0}", element);

            Console.WriteLine();    

            // LINQ query that obtains values greater than 4 from the array
            var filtered =
                from value in values
                where value > 4
                select value;

            // display filtered results
            Console.Write("Array values greater than 4:");
            foreach ( var element in filtered )
                Console.Write(" {0}", element);

            Console.WriteLine();

            // order values using orderby in ascending order
            var sorted =
                from value in values
                orderby value
                select value;

            // display sorted results
            Console.Write("Array sorted: ");
            foreach (var element in sorted)
                Console.Write(" {0}", element);

            Console.WriteLine();    

            // sort and filter
            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;

            // display sortFilteredResults results
            Console.Write("Array sortFilteredResults: ");
            foreach (var element in sortFilteredResults)
                Console.Write(" {0}", element);

            Console.WriteLine();

        }
    }
}
