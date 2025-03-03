namespace Inheritance;

// TODO 1: Examine this class, Bicycle, Car and Lorry
internal class Vehicle
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

    public Vehicle()
    {
        
    }
    public Vehicle(int maxSpeed)
    {
        MAX_SPEED = maxSpeed;
    }

    // TODO 4: Make the methods below overridable
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
        Console.WriteLine($"Car drives with a speed of {CurrentSpeed}km/h");
    }
}
