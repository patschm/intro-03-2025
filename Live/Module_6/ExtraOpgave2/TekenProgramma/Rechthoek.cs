namespace TekenProgramma;

internal class Rechthoek
{
    private int _lengte;
    private int _breedte;

    public ConsoleColor Kleur { get; set; }
    public Positie Positie { get; set; }

    public int Lengte
    {
        get { return _lengte; }
        set
        {
            if (value >= 0)
            {
                _lengte = value;
            }
        }
    }
    public int Breedte
    {
        get { return _breedte; }
        set
        {
            if (value >= 0)
            {
                _breedte = value;
            }
        }
    }

    public void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Rechthoek op ({Positie.Coordinate}) met lengte {Lengte} en breedte {Breedte}");
        Console.ResetColor();
    }
}
