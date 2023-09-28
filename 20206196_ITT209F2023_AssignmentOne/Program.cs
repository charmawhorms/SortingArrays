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
            //Declaring an array that can holds 10 numbers
            int[] userNumbers = new int[10];

            Console.WriteLine("Welcome to the Array Sorter!");
            Console.WriteLine("Enter 10 numbers");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());                
            }

            Console.ReadKey();
        }
    }
}
