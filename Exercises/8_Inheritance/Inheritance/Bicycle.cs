namespace Inheritance;

// TODO 2a: Inherit from Vehicle and remove redundant code.
internal class Bicycle
{
    private readonly int MAX_SPEED = 50;
    private int currentSpeed;

    public int NumberOfGears { get; set; } = 10;
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
    
    // TODO 4a: Override the methods below where necessary.
    public void Throttle()
    {
        CurrentSpeed++;
    }
    public void Brake()
    {
        CurrentSpeed--;
    }
    public void DisplayStatus()
    {
        Console.WriteLine($"The bicycle with {NumberOfGears} gears rides with a speed of {CurrentSpeed}km/h");
    }
}
