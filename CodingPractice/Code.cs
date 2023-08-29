using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodingPractice
{
    class Code
    {
        public static void main(string[] args)

        {
            int[] numbers = { 20, 34, 21, 87, 92, 1785 };

            largestAndsmallest(numbers);
            var result = FizzBuzz(numbers);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

           // largestAndsmallest(int[]{ 11, 834,201});

            //largestAndsmallest(int[]{ 0, 40, 1000000});

            //largestAndsmallest(int[]{ 1, 65536, 0, 34, 376});

        }


        public static void largestAndsmallest(int[] numbers)

        {

            int largest = int.MinValue;

            int smallest = int.MaxValue;

            foreach (int number in numbers)

            {

                if (number > largest) 

                {

                    largest = number;

                }

                if (number <smallest)

                {

                    smallest = number;

                }

            }

            Console.WriteLine("Largest number: " + largest);

            Console.WriteLine("Smallest number: " + smallest);




        }

        public static List<string> FizzBuzz(int[] numbers) //numbers = [45, 22, 14, 65, 97, 72]
        {
            var result = new List<string>();
            foreach(var n in numbers)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (n % 3 == 0)
                    result.Add("Fizz");
                else if (n % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(n.ToString());
            }
            return result;
        }
    }

}


/*

* C# program to find largest and smallest rational number from an array in C#. *

*/


