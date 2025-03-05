namespace Classes;

// TODO 3a: Define a class Car
// TODO 3b: Define the following fields that can be accessed from outside.
//     - brand
//     - model
//     - production year

// TODO 3c: Define the following fields that can be NOT accessed from outside.
//     - current speed
//     - maximum speed

// TODO 4: Declare and initialize two instances of this class where appropriate. 
// Assign values to the fields and display them.

class Car
{
    public string? brand;
    public string? model;
    public int productionYear;
    private int currentSpeed;
    private  int MaxSpeed = 250;
}
