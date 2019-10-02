using System;
using System.Collections.Generic;

namespace Thirteen
{
    class Program
    {
        // 1
        public static void PrintNumbers()
        {// Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }
        // 2
        public static void PrintOdds()
        {// Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i%2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            System.Console.WriteLine("");
        }
        // 3
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255 with the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.Write($"add {i} to {sum}  ");
            }
            // System.Console.WriteLine("");
        }
        // 4
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the
            // given integer array and print each value to the console.
            foreach (int i in numbers)
            {
                System.Console.Write($"{i}. ");
            }
            System.Console.WriteLine("");
        }
        // 5
        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            System.Console.WriteLine($"THE BIGGEST NUMBER IS: {max}.");
        }
        // MIN
        public static void FindMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            System.Console.WriteLine($"THE SMALLEST NUMBER IS: {min}.");
        }
        // 6
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            System.Console.WriteLine($"AVERAGE FOR THIS ARRAY: {(double)sum/numbers.Length}");
        }
        // 7
        public static int[] OddArray()
        {
            int[] odds = new int[128];
            int idx = 0;
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    odds[idx] = i;
                    idx++;
                }
            }
            return odds;
        }

        // 8
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    count++;
                }
            }
            return count;
        }
        // 9
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            foreach (int num in numbers)
            {
                Console.Write($"{num} squares to ");
                int sqr = num * num;
                Console.WriteLine(sqr);
            }
        }
        // 10
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < -1)
                {
                    numbers[i] = 0;
                }
                Console.Write($"{numbers[i]}. ");
            }
            System.Console.WriteLine("");
        }
        // 11
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            FindMin(numbers);
            FindMax(numbers);
            GetAverage(numbers);
        }
        // 12
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length-1; i++)
            {
              numbers[i] = numbers[i+1];
              Console.Write($"{numbers[i]} ");
            }
            numbers[numbers.Length-1] = 0;
            Console.WriteLine(numbers[numbers.Length-1]);
        }
        // 13
        /*public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }*/

        //########   MAIN   ########
        static void Main(string[] args)
        {
            Console.WriteLine("It's alive!");
            int[] tester = {46,45,-7,2,35,58,24,6,16,35,-23};
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(tester);
            // FindMax(tester);
            // FindMin(tester);
            // GetAverage(tester);
            // OddArray();
            // GreaterThanY(tester,9);
            // SquareArrayValues(tester);
            // EliminateNegatives(tester);
            // MinMaxAverage(tester);//this one's good :)
            ShiftValues(tester);
        }
    }
}
