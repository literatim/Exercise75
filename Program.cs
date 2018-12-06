using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");

                var userInput = GetUserInput();
                var squareRoot = CalculateSquareRoot(userInput);

                Console.WriteLine($"The square root of {userInput} is {squareRoot}i.");
 

                Console.Write(Environment.NewLine + "Do you want to continue? (y/n): ");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }

        public static int GetUserInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter a number: ");
            }

            return input;
        }

        public static double CalculateSquareRoot(int userInput)
        {
            int number = userInput;
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }

            return root;
        }
    }
}
