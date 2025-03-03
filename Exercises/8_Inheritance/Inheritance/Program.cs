
namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Bicycle b1 = new Bicycle();
        DriveVehicle(b1);

        Car c1 = new Car();
        DriveVehicle(c1);

        Lorry l1 = new Lorry();
        DriveVehicle(l1);

        
    }

    // TODO 3: Lots of duplicate code below. See if you can clean it up.
    private static void DriveVehicle(Bicycle c)
    {
        while (true)
        {
            var key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    c.Throttle();
                    break;
                case ConsoleKey.DownArrow:
                    c.Brake();
                    break;
            }
            c.DisplayStatus();
        }
    }
    private static void DriveVehicle(Car c)
    {
        while (true)
        {
            var key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    c.Throttle();
                    break;
                case ConsoleKey.DownArrow:
                    c.Brake();
                    break;
            }
            c.DisplayStatus();
        }
    }
    private static void DriveVehicle(Lorry c)
    {
        while (true)
        {
            var key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    c.Throttle();
                    break;
                case ConsoleKey.DownArrow:
                    c.Brake();
                    break;
            }
            c.DisplayStatus();
        }
    }
}
