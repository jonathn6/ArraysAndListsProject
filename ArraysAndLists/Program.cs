using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (var i=0; i<myArray.Length; i++)
            {
                var result = myArray[i] % 2;
                if (result == 0)
                {
                    evens.Add(myArray[i]);
                } else
                {
                    odds.Add(myArray[i]);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("Here is a list of all the even numbers:");
            foreach (var evenNumber in evens)
            {
                Console.Write($"{evenNumber}   ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("And here is a list of all the odd numbers:");
            foreach (var oddNumber in odds)
            {
                Console.Write($"{oddNumber}   ");
            }
        }
    }
}
