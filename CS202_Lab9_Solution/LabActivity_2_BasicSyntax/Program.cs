namespace LabActivity_2_BasicSyntax
{
    /// <summary>
    /// A class responsible for the user interface (console I/O).
    /// This represents the "presentation layer" of the application.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1. Create an INSTANCE of our Calculator object. This is OOP.
            Calculator calculator = new Calculator();

            Console.WriteLine("--- Object-Oriented Calculator ---");

            Console.Write("Enter the first number: ");
            double.TryParse(Console.ReadLine(), out double num1);

            Console.Write("Enter the second number: ");
            double.TryParse(Console.ReadLine(), out double num2);

            try
            {
                // 2. Call methods ON THE OBJECT to get the results.
                double sum = calculator.Add(num1, num2);
                double difference = calculator.Subtract(num1, num2);
                double product = calculator.Multiply(num1, num2);
                double quotient = calculator.Divide(num1, num2); // This might throw an exception

                // 3. Display the results.
                Console.WriteLine("\n--- Results ---");
                Console.WriteLine($"{num1} + {num2} = {sum}");
                Console.WriteLine($"{num1} - {num2} = {difference}");
                Console.WriteLine($"{num1} * {num2} = {product}");
                Console.WriteLine($"{num1} / {num2} = {quotient}");

                // 4. Use the calculator's logic to determine the output message.
                if (calculator.IsSumEven(num1, num2))
                {
                    Console.WriteLine($"The sum ({sum}) is an even number.");
                }
                else
                {
                    Console.WriteLine($"The sum ({sum}) is an odd number.");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Catch the specific error from our calculator and display a friendly message.
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
