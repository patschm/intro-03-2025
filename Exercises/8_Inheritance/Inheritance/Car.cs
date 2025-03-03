namespace Inheritance;

// TODO 2b: Inherit from Vehicle and remove redundant code.
internal class Car
{
    private readonly int MAX_SPEED = 260;
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
    public int NumberOfDoors { get; set; } = 3;

    // TODO 4b: Override the methods below where necessary.
    public void Throttle()
    {
        CurrentSpeed += 20;
    }
    public void Brake()
    {
        CurrentSpeed -= 20;
    }
    public void DisplayStatus()
    {
        Console.WriteLine($"The {NumberOfDoors}-doors car drives with a speed of {CurrentSpeed}km/h");
    }
}
