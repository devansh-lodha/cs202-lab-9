namespace LabActivity_3_LoopsAndFunctions
{
    /// <summary>
    /// The presentation layer for demonstrating loops and functions.
    /// It provides a menu to the user to run the different demonstrations.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Loops and Functions Menu ---");
                Console.WriteLine("1. Demonstrate For Loop (1-10)");
                Console.WriteLine("2. Demonstrate ForEach Loop (1-10)");
                Console.WriteLine("3. Demonstrate Do-While Loop (exit on 'exit')");
                Console.WriteLine("4. Calculate Factorial");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LoopAndFunctionDemos.DemonstrateForLoop();
                        break;
                    case "2":
                        LoopAndFunctionDemos.DemonstrateForEachLoop();
                        break;
                    case "3":
                        LoopAndFunctionDemos.DemonstrateDoWhileLoop();
                        break;
                    case "4":
                        Console.Write("Enter a non-negative number to calculate its factorial: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            try
                            {
                                long factorial = LoopAndFunctionDemos.CalculateFactorial(number);
                                Console.WriteLine($"The factorial of {number} is: {factorial}");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
