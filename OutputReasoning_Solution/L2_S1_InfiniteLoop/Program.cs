try
{
    int i = int.MaxValue;
    Console.WriteLine(-(i + 1) - i);
    Console.WriteLine("Program will now hang. Press the Stop button in Visual Studio to terminate.");
    for (i = 0; i <= int.MaxValue; i++) ; // Semicolon causes infinite loop
    Console.WriteLine("This line will never be reached.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
