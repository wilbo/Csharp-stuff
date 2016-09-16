using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
		{   
			int[] numbers = { 9, 7, 3, 8, 5 }; 
		    
			BubbleSort(numbers, LesserThan);                                
		    for (int i = 0; i < numbers.Length; i++)  
			{
		    	Console.WriteLine(numbers[i]);
		    }
		}

        public delegate bool ComparisonHandler(int first, int second);

		public static void BubbleSort(int[] items, ComparisonHandler comparisonMethod) 
		{

		    int i;
			int j;
			int temp;

		    if(comparisonMethod == null)  { throw new ArgumentNullException("comparisonMethod"); }

		    if(items==null) { return;}

		    for (i = items.Length - 1; i >= 0; i--)  
			{
		        for (j = 1; j <= i; j++)   
				{
		           	if (comparisonMethod(items[j - 1], items[j]))             
		        	{
			        	temp = items[j - 1];
			            items[j - 1] = items[j];
		                items[j] = temp;
		            }
				}
			}
		}	

		public static bool GreaterThan(int first, int second) 
		{ 
			return first > second; 
		}

		public static bool LesserThan(int first, int second)
		{
			return first < second;
		}

    }
}
