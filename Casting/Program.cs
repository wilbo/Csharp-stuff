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


            // user defined casting    
            int age = 22;
            Person p2 = (Person) age;

            Console.WriteLine("Person’s name: {0}, Person’s age: {1}", p2.Name, p2.Age);

        }
    }
}
