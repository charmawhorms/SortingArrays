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
            //Function call for the welcome message
            WelcomeBanner();

            bool exitProgram = false;
            do
            {
                //Declaring an array that can hold 10 numbers
                int[] userNumbers = new int[10];

                //do not allow float or letters

                Console.WriteLine("\nEnter 10 integers that you would like to sort");
                
                //Loop that asks the user to enter 10 integers and stores it in an array
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    string userInput = Console.ReadLine();

                    int number;
                    bool validInput = int.TryParse(userInput, out number);

                    while (!validInput)
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        userInput = Console.ReadLine();

                        validInput = int.TryParse(userInput, out number);
                    }

                    userNumbers[i] = number;     
                }

                Console.Clear();
                WelcomeBanner();


                Console.WriteLine("\nSort the integer array in ascending or descending order");

                Console.WriteLine("Enter");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To sort in ascending order");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To sort in descending order");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  3. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To exit the program");

                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nUnsorted integers: ");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var userNum in userNumbers)
                {
                    Console.Write(userNum + " ");
                }

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nSorted integers in ascending order: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    userNumbers = SortArray(userNumbers, 1);
                }
                else if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nSorted Numbers in descending order: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    userNumbers = SortArray(userNumbers, 2);
                }
                else if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThank you for using the Array Sorter!");
                    Console.ReadKey();
                    exitProgram = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid response");
                }

                foreach (var sortedNum in userNumbers)
                {
                    Console.Write(sortedNum + " ");
                }

                Console.WriteLine("\nWould you like to enter 10 integers again? (Y/N)");
                string answer = Console.ReadLine().ToUpper();

                // If the user didn't enter "y", ask them again.
                while (answer != "Y" && answer != "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou have entered an invalid option, please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter Y or N: ");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThank you for using the Array Sorter!");
                    Console.ReadKey();
                    exitProgram = true;
                }
            } while (!exitProgram) ;
        }

        public static void WelcomeBanner() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" _____                                                       _____ \r\n" +
                "( ___ )-----------------------------------------------------( ___ )\r\n" +
                " |   | __        __   _                            _         |   | \r\n" +
                " |   | \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___   |   | \r\n" +
                " |   |  \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\  |   | \r\n" +
                " |   |   \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | |   | \r\n" +
                " |   |  _ \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  |   | \r\n" +
                " |   | | |_| |__   ___     / \\   _ __ _ __ __ _ _   _        |   | \r\n" +
                " |   | | __| '_ \\ / _ \\   / _ \\ | '__| '__/ _` | | | |       |   | \r\n" +
                " |   | | |_| | | |  __/  / ___ \\| |  | | | (_| | |_| |       |   | \r\n" +
                " |   |  \\__|_| |_|\\___| /_/   \\_\\_|  |_|  \\__,_|\\__, |       |   | \r\n" +
                " |   | / ___|  ___  _ __| |_ ___ _ __| |        |___/        |   | \r\n" +
                " |   | \\___ \\ / _ \\| '__| __/ _ \\ '__| |                     |   | \r\n" +
                " |   |  ___) | (_) | |  | ||  __/ |  |_|                     |   | \r\n" +
                " |   | |____/ \\___/|_|   \\__\\___|_|  (_)                     |   | \r\n" +
                " |___|                                                       |___| \r\n" +
                "(_____)-----------------------------------------------------(_____)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Method that is responsible for sorting the array in an ascending
        //or descending order
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
