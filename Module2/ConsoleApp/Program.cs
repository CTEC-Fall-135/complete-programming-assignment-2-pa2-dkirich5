/*
Author: Daniel Kirichenko
Date: 10/06/2025
Assignment: Programming Assignment 2
*/

using System;

namespace WorkflowDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Task2 Part 1
            #region Task2 Part 1
            // Declare an int variable and set it to the max volume
            int myInt = int.MaxValue;

            // Print the value both as a normal int and in its Hex format
            Console.WriteLine($"Max int value: {myInt}");
            Console.WriteLine($"Max int value in Hex: {myInt:X}");

            // increment the variable by one (causing overflow)
            myInt++;
            Console.WriteLine($"\nAfter increment: {myInt}");
            Console.WriteLine($"After increment in Hex: {myInt:X}");

            // Set the variable to 0 and print its value
            myInt = 0;
            Console.WriteLine($"\nReset to zero: {myInt}");

            // Decrement the variable by one (causing underflow)
            myInt--;
            Console.WriteLine($"\nAfter decrement: {myInt}");
            Console.WriteLine($"After decrement in Hex: {myInt:X}");
            #endregion

            Console.WriteLine(); // blank line for readability

            // Casting Section
            #region Casting
            //Assign the max value to your int variable
            int maxInt = int.MaxValue;

            // Declare a short variable and initialize its value to the int variable using casting
            short shortNum = (short)maxInt;

            // Print the int variable as a number and in the hexadecimal format
            Console.WriteLine($"\nCasting Selection: ")
            Console.WriteLine($"Int value: {maxInt}");
            Console.WriteLine($"Int value in Hex: {maxInt:X}");

            // Print the short variable as a number and in the hexadecimal format
            Console.WriteLine($"Short value: {shortNum}");
            Console.WriteLine($"Short value in Hex: {shortNum:X}");
            #endregion

            Console.WriteLine(); // blank line for readability

            // Task 3: Arrauys and Loops
            #region Loops
            // Declaring an array if ints the size of 5
            int[] numbers = new int[5];

            // Initialize array values
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            // Print array values
            Console.Write("Array values: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine(); // blank line for readability

            #region Loop bonus

            // Task 3 Bonus: Multiplication Table
            Console.WriteLine("Multiplication Table:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j,}\t");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine(); // blank line for readability

            // Task 4: Printer Troubleshoter Program
            #region Printer troubleshooter
            string condition = "";

            // First Question
            Console.Write("\nIs the printer turned on? (Y/N): ");
            condition += Console.ReadLine()?.Trim().ToUpper() == "Y" ? "Y" : "N";

            // Second Question
            Console.Write("Does the printer have paper? (Y/N): ");
            condition += Console.ReadLine()?.Trim().ToUpper() == "Y" ? "Y" : "N";


            //Third Question
            Console.Write("Is there a paper jam? (Y/N): ");
            condition += Console.ReadLine()?.Trim().ToUpper() == "Y" ? "Y" : "N";

            // Console.WriteLine($"Condition code: {condition}"); // For testing

            switch (condition)
            {
                case "YYY":
                    Console.WriteLine("No problems detected");
                    break;
                case "YYN":
                    Console.WriteLine("Check for other issues. Printer seems fine.");
                    break;
                case "YNY":
                    Console.WriteLine("Check for a paper jam.");
                    break;
                case "YNN":
                    Console.WriteLine("Load paper into printer.");
                    break;
                case "NYY":
                    Console.WriteLine("Turn on the printer.");
                    break;
                case "NYN":
                    Console.WriteLine("Turn on the printer and load paper");
                    break;
                case "NNY":
                    Console.WriteLine("Turn on the printer and check for a paper jam.");
                    break;
                case "NNN":
                    Console.WriteLine("Turn on the printer and load paper");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please use Y or N only.");
                    break;
            }
            #endregion
        }
    }
}

