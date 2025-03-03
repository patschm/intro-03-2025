namespace Expresso;

class Program
{
    static void Main(string[] args)
    {
        int bx = 8;
        int a = 10;
        Console.WriteLine(a);
        int result = a + 5; // nested expression. From left to right, a + 5 is evaluated first, then the result is added to a.  
        Console.WriteLine(result);
        Console.WriteLine(result++);
        Console.WriteLine(-result);

        int nr = -2;

        result = result + 10;
        result += 10; // Compound assignment operator

        double res2 = 10 / 20D;
        Console.WriteLine(res2);

        int bbb = 3;
        bool ba = true;
        bool bb = false;
        bool bc = ba && bb;
        //bool bresult = true && false;
        bool bd = bbb > 10 && bbb < 20;
        bool be = bbb == 4;

        int? age = null;

        if (age.HasValue)
        {
            Console.WriteLine($"Age is not null ({age.Value})");
        }
        else
        {
            Console.WriteLine("Age is null (0)");
        }

        int age2 = age != null ? age.Value : 0;
        Console.WriteLine(age2);

        int age3 = age ?? 0;
        Console.WriteLine(age3);

        // Nullable types
        int? i = null;  
        string? s = null;
        System.Console.WriteLine(s!.Length);
    }
}
