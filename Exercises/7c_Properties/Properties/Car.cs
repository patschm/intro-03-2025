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
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime ProductionDate { get; set; }

    private int currentSpeed;
    private readonly int maximumSpeed;

    public int Age
    {
        get
        {
            return DateTime.Now.Year - ProductionDate.Year;
        }
        
    }
    public int CurrentSpeed
    {
        get { return currentSpeed; }
        private set
        {
            if (value >= 0 && value < maximumSpeed)
            {
                currentSpeed = value;
            }
        }
    }

    public void SpeedUp()
    {
        if (CurrentSpeed >=0 && CurrentSpeed < maximumSpeed)
        {
            CurrentSpeed++;
        }
    }
    public void Brake()
    {
        CurrentSpeed--;
    }
    public void DisplaySpeed()
    {
        Console.WriteLine($"Current speed is {CurrentSpeed}");
    }

    public Car(int maxSpeed)
    {
        maximumSpeed = maxSpeed;
    }
}

