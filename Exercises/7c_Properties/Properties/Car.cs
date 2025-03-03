namespace Properties;

// TODO 1a: Define a property for currentSpeed.
// Make sure the values lies between 0 en maxSpeed
// Use this property instead of the field where possible.

// TODO 2a: Define properties for brand, model en productionDate.
// Use the property instead of the field

// TODO 3: Modify the property for currentSpeed to make it read only.

// TODO 4: Create a property that can be used to query the car's age.

class Car
{
    public string brand;
    public string model;
    public DateTime productionDate;

    private int currentSpeed;
    private readonly int maximumSpeed;

    public void SpeedUp()
    {
        if (currentSpeed < maximumSpeed) currentSpeed++;
    }
    public void Brake()
    {
        currentSpeed--;
    }
    public void DisplaySpeed()
    {
        Console.WriteLine($"Current speed is {currentSpeed}");
    }

    public Car(int maxSpeed)
    {
        maximumSpeed = maxSpeed;
    }
}

