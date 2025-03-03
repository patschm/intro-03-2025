namespace Operators;
#pragma warning disable CS0219

internal class Program
{
    static void Main(string[] args)
    {
        int a = 10; 
        int b = 20;

        // TODO 1a: Add a and b and display the result.
        int res= a + b;
        Console.WriteLine(res);
        // TODO 1b: Subtract a and b and display the result.

        res = a - b;
        Console.WriteLine(res);
        // TODO 1c: Multiply a and b and display the result.
        res = a * b;
        Console.WriteLine(res);
        // TODO 1d: Divide a and b and display the result.
        double res2 = a / (double)b;
        Console.WriteLine(res2);

        // TODO 2a: increase a by 2 and display the result.
        a += 2;
        Console.WriteLine(a);
        // TODO 2b: decrease a by 2 and display the result.
        a-= 2;
        Console.WriteLine(a);
        // TODO 2c: increase b by 1 and display the result.
        b++;
        Console.WriteLine($"De waarde is {a}, {b}");
        // TODO 2d: decrease b by 1 and display the result.
        Console.WriteLine(--b);
        int c = Random.Shared.Next(1, 3);
        // TODO 3a: Declare a variable that stores whether c equals 2.
        bool ok = c == 2;
        Console.WriteLine(ok);
        // TODO 3b: Declare a variable that stores whether c is not equal to 2.
        ok = c != 2;
        Console.WriteLine(ok);
        // TODO 3c: Declare a variable that stores whether or not c greater than 2.
        Console.WriteLine(c > 2);
        // TODO 3d: Declare a variable that stores whether or not c less than 2.
        Console.WriteLine(c <2);
        // TODO 4: Make sure the result of the next calculation is 60
        int result = (10 + 20) * 2;
        Console.WriteLine(result);
    }
}
