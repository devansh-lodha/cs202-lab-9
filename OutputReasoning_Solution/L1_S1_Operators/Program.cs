int a = 0;
int b = a++;
// The following line is compiler-dependent and bad practice.
// We are running it solely to verify the lab sheet's specific behavior.
Console.WriteLine(a++.ToString(), ++a, -a++);
Console.WriteLine((a++).ToString() + (-a++).ToString());
Console.WriteLine(~b);
