namespace Properties;

internal class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car(180);
        c1.brand = "Volkswagen";
        c1.model = "Polo";
        c1.productionDate = DateTime.Now.AddYears(-2);

        while (true)
        {
            var key = Console.ReadKey();
            Console.Clear();
            
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    c1.SpeedUp();
                    break;
                case ConsoleKey.DownArrow:
                    c1.Brake();
                    break;
            }
            c1.DisplaySpeed();
        }
    }
}
