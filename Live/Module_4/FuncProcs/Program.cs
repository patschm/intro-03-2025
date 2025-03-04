namespace FuncProcs;

class Program
{
    static void Main(string[] args)
    {
        string? name2 = AskForName();
        SayHello(name2);
    }

    // You define functions and procedures at this scope.
    // Procedure
    // static DOES NOT BELONG to the procedure definition.
    static void SayHello()
    {
        Console.WriteLine("Hello");
    }
    // If I need input fro the outside world, I need to pass it in as a parameter.
    // name is the parameter and follows the same rules as a variable.
    static void SayHello(string? name)
    {       
        Console.WriteLine($"Hello {name}");
    }

    // Function
    static string? AskForName()
    {
        Console.WriteLine("What is your name?");
        string? myName = Console.ReadLine();
        return myName;
    }
}
