namespace Branching;
#pragma warning disable CS0219


// TODO 1a: Can I use an if-statement here?
// Can I use a switch statement here?
// Neen
internal class Program
{
    // TODO 1b: Can I use an if-statement here?
    // Can I use a switch statement here?
    //Nee
    static void Main(string[] args)
    {
        // TODO 1c: Can I use an if-statement here?
        // Can I use a switch statement here?
        // Ja
        {
            // TODO 1d: Can I use an if-statement here?
            // Can I use a switch statement here?
            // Ja
            {
                // TODO 1e: Can I use an if-statement here?
                // Can I use a switch statement here?
                // Ja
            }
        }

        // Write a flow that shows the following:
        // number less than 100: message number below hundred.
        // number greater than 100 and less than 200: message number between 100 and 200
        // number exactly 100: message number is 100
        int number = Random.Shared.Next(0, 200);
        if (number < 100)
        {
            Console.WriteLine("number below hundred.");
        }
        else if (number > 100 && number < 200)
        {
            Console.WriteLine("number between 100 and 200");
        }
        else if (number == 100)
        {
            Console.WriteLine("number is 100");
        }

        // Write a flow that translates the number to a human readable representation. e.g.
        // 1 will be written as one,  2 wil be written as two, etc.
        byte choice = (byte)Random.Shared.Next(0, 5);

        switch (choice)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            default:
                Console.WriteLine("Any");
                break;
        }

    }

    static void DoSomething()
    {
        // TODO 1f: Can I use an if-statement here?
        // Can I use a switch statement here?
        // Ja

    }
    // TODO 1g: Can I use an if-statement here?
    // Can I use a switch statement here?
    // Nee

}
// TODO 1h: Can I use an if-statement here?
// Can I use a switch statement here?
// Neen
