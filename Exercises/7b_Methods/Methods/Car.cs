namespace Methods;

// TODO 1a: Define a method to display the current speed.
// and call the method in Program main() after the switch statement

// TODO 2a: Define a method Speedup that increments the current speed.
// Make sure the current speed does not exceed the maximum speed.
// Call the speed up in the ConsoleKey.UpArrow section

// TODO 3a: Define a method Brake that decrements the current speed.
// Call the speed up in the ConsoleKey.DownArrow section

// TODO 4: Find a way to provide a value maximumSpeed from the outside without making it public.


class Car
{
    public string brand;
    public string model;
    public DateTime productionDate;

    private int currentSpeed;
    private int maximumSpeed = 220;

    public void SpeedUp()
    {
        if (currentSpeed < maximumSpeed)
        {
            currentSpeed++;
        }
    }
    public void Brake()
    {
        currentSpeed -= 1;
    }
    public void ShowCurrentSpeed()
    {
        Console.WriteLine($"De huidige snelheid van de {brand} {model} is {currentSpeed}km/h");
    }
    public Car(int maxSpeed)
    {
        this.maximumSpeed = maxSpeed;
    }
}

