using System;

namespace ConsoleApplication
{
    public class Program
    {

        // Casting means moving a datatype to another datatype

        public static void Main(string[] args)
        {

            double myDouble = 100.25;
            int myInt = (int) myDouble; // explicit casting -> data loss
            myDouble = myInt; // implicit casting

            Console.WriteLine("explicit: {0}, implicit: {1}", myInt, myDouble);
        }
    }
}
