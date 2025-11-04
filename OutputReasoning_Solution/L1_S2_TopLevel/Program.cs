namespace L1_S2_TopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Logic from the snippet begins here ---

            int x = 3;
            int y = 2 + ++x;
            Console.WriteLine($"x = {x} and y = {y}");

            x = 3 << 2;
            y = 10 >> 1;
            Console.WriteLine($"x = {x} and y = {y}");

            x = ~x;
            y = ~y;
            Console.WriteLine($"x = {x} and y = {y}");

            // --- End of snippet logic ---
        }
    }
}