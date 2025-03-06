namespace TekenProgramma;

internal class Driehoek: Vorm
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
   

    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Driehoek op ({Positie.Coordinate}) met basis {Basis}, hoogte {Hoogte} en hoek {Hoek}");
        Console.ResetColor();
    }
}
