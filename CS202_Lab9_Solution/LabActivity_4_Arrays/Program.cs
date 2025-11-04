using System.Text;

namespace LabActivity_4_Arrays
{
    /// <summary>
    /// The presentation layer for demonstrating array manipulations.
    /// It creates sample data and uses the ArrayManipulator class to perform operations.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayManipulator manipulator = new ArrayManipulator();

            // --- 1. Bubble Sort Demonstration ---
            Console.WriteLine("--- 1. Bubble Sort ---");
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine($"Original Array : {FormatArray(unsortedArray)}");
            int[] sortedArray = manipulator.BubbleSort(unsortedArray);
            Console.WriteLine($"Sorted Array   : {FormatArray(sortedArray)}");
            Console.WriteLine();

            // --- 2. 2D Array to 1D Conversion ---
            Console.WriteLine("--- 2. 2D to 1D Conversion ---");
            int[,] matrixToConvert = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Original Matrix:");
            Console.WriteLine(FormatMatrix(matrixToConvert));
            int[] rowMajor = manipulator.ConvertToRowMajor(matrixToConvert);
            Console.WriteLine($"Row-Major Order    : {FormatArray(rowMajor)}");
            int[] colMajor = manipulator.ConvertToColumnMajor(matrixToConvert);
            Console.WriteLine($"Column-Major Order : {FormatArray(colMajor)}");
            Console.WriteLine();

            // --- 3. Matrix Multiplication ---
            Console.WriteLine("--- 3. Matrix Multiplication ---");
            int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 } }; // 2x3
            int[,] matrixB = { { 7, 8 }, { 9, 10 }, { 11, 12 } }; // 3x2
            Console.WriteLine("Matrix A (2x3):");
            Console.WriteLine(FormatMatrix(matrixA));
            Console.WriteLine("Matrix B (3x2):");
            Console.WriteLine(FormatMatrix(matrixB));
            int[,] matrixC = manipulator.MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("Resultant Matrix C (2x2):");
            Console.WriteLine(FormatMatrix(matrixC));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Helper function to format a 1D array for printing
        private static string FormatArray(int[] arr) => $"[{string.Join(", ", arr)}]";

        // Helper function to format a 2D array for printing
        private static string FormatMatrix(int[,] matrix)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j],-4}"); // Pad with spaces for alignment
                }
                sb.AppendLine("]");
            }
            return sb.ToString();
        }
    }
}
