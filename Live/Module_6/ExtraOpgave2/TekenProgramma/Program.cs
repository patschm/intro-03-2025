namespace TekenProgramma;

internal class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        Vorm c1 = new Cirkel();
        c1.Positie = RandomPositie();
        c1.Kleur = ConsoleColor.Red;
        canvas.VoegToe(c1);

        Rechthoek r1 = new Rechthoek();
        r1.Positie = RandomPositie();
        r1.Kleur = ConsoleColor.Green;
        r1.Breedte = 200;
        r1.Lengte = 100;
        canvas.VoegToe(r1);

        Driehoek d1= new Driehoek();
        d1.Positie= RandomPositie();
        d1.Kleur = ConsoleColor.Blue;
        d1.Basis = 300;
        d1.Hoogte = 100;
        d1.Hoek = -180;       
        canvas.VoegToe(d1);
 

        Console.WriteLine("Press Enter to add a cirkel");
        Console.ReadLine();

        Cirkel c2 = new Cirkel
        {
            Positie = RandomPositie(),
            Kleur = ConsoleColor.Blue,
            Straal = 200
        };

        canvas.VoegToe(c2);   
       
        // Advanced
        ConsoleKey key;
        do
        {
            Console.WriteLine("Press C to add a circle");
            Console.WriteLine("Press R to add a rectangle");
            Console.WriteLine("Press D to add a triangle");

            key = Console.ReadKey().Key;
            switch(key)
            {
                case ConsoleKey.R:
                    Rechthoek r = CreateRechthoek();
                    canvas.VoegToe(r);
                    break;
                case ConsoleKey.C:
                    Cirkel c = CreateCirkel();
                    canvas.VoegToe(c);
                    break;
                case ConsoleKey.D:
                    Driehoek d = CreateDriehoek();
                    canvas.VoegToe(d);
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }
        while (true);
    }

    static Cirkel CreateCirkel()
    {
        Cirkel c1 = new Cirkel();
        c1.Kleur = (ConsoleColor)Random.Shared.Next(0, 16);
        c1.Positie = RandomPositie();       
        c1.Straal = Random.Shared.Next(10, 300);
        return c1;
    }

    static Rechthoek CreateRechthoek()
    {
        Rechthoek r1 = new Rechthoek();
        r1.Kleur = (ConsoleColor)Random.Shared.Next(0, 16);
        r1.Positie = RandomPositie();
        r1.Breedte = Random.Shared.Next(10, 400);
        r1.Lengte = Random.Shared.Next(0, 400); ;
        return r1;
    }

    static Driehoek CreateDriehoek()
    {
        Driehoek d1 = new Driehoek();
        d1.Kleur = (ConsoleColor)Random.Shared.Next(0, 16);
        d1.Positie = RandomPositie();
        d1.Basis = Random.Shared.Next(10, 400);
        d1.Hoogte = Random.Shared.Next(0, 400);
        d1.Hoek = Random.Shared.Next(-360, 360);
        return d1;
    }

    static Positie RandomPositie()
    {
        return new Positie {
            X = Random.Shared.Next(0, 500),
            Y = Random.Shared.Next(0, 500)
        };
    }
}
