namespace TekenProgramma;

internal class Rechthoek : Vorm
{
    private int _lengte;
    private int _breedte;

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

    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Rechthoek op ({Positie.Coordinate}) met lengte {Lengte} en breedte {Breedte}");
        Console.ResetColor();
    }
}
