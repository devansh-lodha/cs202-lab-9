namespace L2_S2_InvalidSyntax
{
    internal class Program
    {
        // A valid Main method is included so the compiler can attempt to build the project.
        static void Main(string[] args)
        {
            // This method is empty because the error occurs before execution.
        }

        // The following line is the invalid snippet from the lab assignment.
        // It is placed at the class level, where executable statements are not allowed.
        // This will cause compilation errors, which is the expected result of this test.
        Main(["CS202"]);
    }
}