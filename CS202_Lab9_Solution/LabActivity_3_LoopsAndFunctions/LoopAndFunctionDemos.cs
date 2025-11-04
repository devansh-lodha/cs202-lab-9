namespace LabActivity_3_LoopsAndFunctions
{
    /// <summary>
    /// Contains the business logic for demonstrating various loop and function types.
    /// This is a static class as it groups related utility functions that do not
    /// depend on an object's state.
    /// </summary>
    public static class LoopAndFunctionDemos
    {
        public static void DemonstrateForLoop()
        {
            Console.Write("\nFor Loop Output: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void DemonstrateForEachLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("\nForEach Loop Output: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        public static void DemonstrateDoWhileLoop()
        {
            string? input;
            Console.WriteLine("\nEnter any text. Type 'exit' to end the loop.");
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine($"You entered: {input}");

            } while (input?.ToLower() != "exit");
            Console.WriteLine("Exiting do-while loop.");
        }

        public static long CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (number == 0)
            {
                return 1; // Base case: factorial of 0 is 1.
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
