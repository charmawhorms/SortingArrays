using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206196_ITT209F2023_AssignmentOne
{
    internal class Program
    {
        /*
         * ===============================
         * ID: 20206196
         * Student Name: Charma Whorms
         * ===============================
         */

        static void Main(string[] args)
        {
            //Declaring an array that can hold 10 numbers
            int[] userNumbers = new int[10];

            Console.WriteLine("Welcome to the Array Sorter!");
            Console.WriteLine("Enter 10 numbers");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());                
            }

            bool exitProgram = false;
            //int choice = 0;
            while (!exitProgram)
            {
                Console.WriteLine("\n Sort the array in ascending or descending order");
                Console.WriteLine("Enter \n 1. To sort in ascending order \n 2. To sort in descending order \n 3. To exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Unsorted numbers: ");
                foreach (var userNum in userNumbers)
                {
                    Console.WriteLine(userNum + " ");
                }

                if ( choice == 1 )
                {
                    Console.WriteLine("Sorted Numbers in ascending order");
                    userNumbers = SortArray(userNumbers , 1);
                }
                else if ( choice == 2 )
                {
                    Console.WriteLine("Sorted Numbers in descending order");
                    userNumbers = SortArray(userNumbers, 2);
                }
                else if ( choice == 3)
                {
                    exitProgram = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid response");
                }

                foreach (var sortedNum in userNumbers)
                {
                    Console.WriteLine(sortedNum + " ");
                }
                Console.ReadKey();
            }
        }

        public static int[] SortArray(int[] array, int order)
        {
            var arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    // Check the sort order parameter to determine how to compare the elements.
                    if (order == 1 && array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                    else if (order == 2 && array[j] > array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = tempVar;
            }

            return array;
        }



    }
}
