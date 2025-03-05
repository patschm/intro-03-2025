namespace Properties;

internal class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car(180);
        c1.Brand = "Volkswagen";
        c1.Model = "Polo";
        c1.ProductionDate = DateTime.Now.AddYears(-2);

        Console.WriteLine(c1.Age);
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
