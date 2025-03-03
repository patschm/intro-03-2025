namespace Inheritance;

// TODO 2c: Inherit from Vehicle and remove redundant code.
internal class Lorry
{
    private readonly int MAX_SPEED = 100;
    private int currentSpeed;

    public int CurrentSpeed
    {
        get
        {
            return currentSpeed;
        }
        set
        {
            if (currentSpeed >= MAX_SPEED && currentSpeed >= 0)
            {
                currentSpeed = value;
            }
        }
    }
    public int MaxLoad { get; set; } = 20_000;

    // TODO 4b: Override the methods below where necessary.
    public void Throttle()
    {
        CurrentSpeed += 8;
    }
    public void Brake()
    {
        CurrentSpeed -= 8;
    }
    public void DisplayStatus()
    {
        Console.WriteLine($"The lorry with a maximum load of {MaxLoad}kg drives with a speed of {CurrentSpeed}km/h");
    }
}
