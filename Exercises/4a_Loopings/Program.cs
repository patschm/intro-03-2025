namespace Loopings;

internal class Program
{
    static void Main(string[] args)
    {
        // TODO 1: Write the following piece of code more efficiently
        //Console.WriteLine("Hello, World 1 !");
        //Console.WriteLine("Hello, World 2 !");
        //Console.WriteLine("Hello, World 3 !");
        //Console.WriteLine("Hello, World 4 !");
        //Console.WriteLine("Hello, World 5 !");
        //Console.WriteLine("Hello, World 6 !");
        //Console.WriteLine("Hello, World 7 !");
        //Console.WriteLine("Hello, World 8 !");
        //Console.WriteLine("Hello, World 9 !");
        //Console.WriteLine("Hello, World 10 !");

        //int x = 10, y = 20;

        for(int i = 1; i <= 10; i++) 
        {
            Console.WriteLine($"Hello World! {i}");
        }

        // TODO 2: Calculate the sum of all the numbers between 1 and 100
        int total = 0;
        for(int number = 1; number <= 100; number++) 
        {
            total += number;
        }
        Console.WriteLine(total);

        total = 0;
        for (int number = 1; number <= 100; total += number++) ;
        Console.WriteLine(total);

        // TODO 3: Display the tables from 1 to 10
        for(int tafel = 1; tafel <= 10; tafel++) 
        {
            Console.WriteLine($"De tafel van {tafel}");
            for (int teller = 1; teller <= 10; teller++)
            {
                int result = teller * tafel;
                Console.WriteLine($"{teller} x {tafel} = {result}");
            }
            Console.WriteLine();
        }
    }
}
