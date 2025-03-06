namespace TekenProgramma;

internal class Driehoek
{
    private int _hoogte;
    private int _basis;

    public int Hoogte
    {
        get { return _hoogte; }
        set
        {
            if (value >= 0)
            {
                _hoogte = value;
            }
        }
    }
    public int Basis
    {
        get { return _basis; }
        set
        {
            if (value >= 0)
            {
                _basis = value;
            }
        }
    }
    public int Hoek { get; set; }
    public ConsoleColor Kleur { get; set; }
    public Positie Positie { get; set; }


    public void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Driehoek op ({Positie.Coordinate}) met basis {Basis}, hoogte {Hoogte} en hoek {Hoek}");
        Console.ResetColor();
    }
}
