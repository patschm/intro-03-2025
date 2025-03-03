namespace Loopings;

internal class Program
{
    static void Main(string[] args)
    {
        // TODO 1: Create a loop that runs until the random number rnd equals 444
        int rnd = Random.Shared.Next(0, 10_000);

        // TODO 2: Create a loop that reads all values from a stack (First In - Last Out principle)
        // untill the stack is empty.
        // To retrieve the last added element on a stack call Pop() (See code frafment below).
        // Every time you call Pop() the element will also be removed from the stack. You can 
        // examine the size of the stack by using stack.Count. If stack.Count is 0 the stack is empty.
        rnd = Random.Shared.Next(0, 20);
        var stack = new Stack<int>(Enumerable.Range(0, rnd));
        int number = stack.Pop();
        
        
    }
}
