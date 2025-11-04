namespace LabActivity_2_BasicSyntax
{
    /// <summary>
    /// A class responsible for performing basic arithmetic operations.
    /// This represents the "business logic" layer of the application.
    /// </summary>
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            // A professional implementation includes error handling.
            if (b == 0)
            {
                // Throwing an exception is a standard way to handle critical errors.
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public bool IsSumEven(double a, double b)
        {
            // The modulo operator (%) gives the remainder of a division.
            return (a + b) % 2 == 0;
        }
    }
}