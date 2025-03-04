namespace JumpBack;

class Program
{
    static void Main(string[] args)
    {
        int teller = 0;

        // Use the for-loop if you know exactly how many times you want to loop.
        //for(;;)
        // for(teller = 0; teller < 100;teller++)
        // {
        //     Console.WriteLine($"Hello World! ({teller++})");
        //     if (teller > 10) continue;
        //     System.Console.WriteLine("En verder...");
        // }
        // System.Console.WriteLine(teller);

        // Use the while-loop if you don't know how many times you want to loop.
        // Zero or more times.
        // Database uitlezen
        while(teller < 10)
        {
            System.Console.WriteLine(teller++);
        }

        // Use the do-while-loop if you don't know how many times you want to loop.
        // At least once.
        // User input.
        do
        {
            System.Console.WriteLine(teller++); 
        }
        while(teller < 20);
    }
}
