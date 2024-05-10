using System;

namespace Reverse 
{
    internal class myProgram
    {
        static void Main(string[] args)
        {   

            // Here we ask the user how many numbers they would like to be printed out, collects the input and converts it to an integer.

            Console.WriteLine("Tell me the number of integers you want printed out in reversed order: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify which numbers: ");

            // Then we create a new array to store the numbers the user gives us.

            int[] numbers = new int[n];

            // Then we loop through the input and converts it to integers.

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here are your numbers: ");

            // This next for Loop takes the given numbers (n), subtracts it with 1 to find the last number in the index, since index 1 is number 0 in the index etc. So if n = 5, the last index is 4 (n-1).

            for (int i = n - 1; i >= 0; i--) 
            {
                Console.WriteLine(numbers[i]);
            }

         
        }
    }
}