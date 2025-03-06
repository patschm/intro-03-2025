namespace TekenProgramma;

internal class Cirkel
{
    private int _straal;
    public ConsoleColor Kleur { get; set; }
    public Positie Positie { get; set; }

    public int Straal
    {
        get { return _straal; }
        set
        {
            if (value >= 0)
            {
                _straal = value;
            }
        }
    }

    public void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Cirkel op ({Positie.Coordinate}) met straal {Straal}");
        Console.ResetColor();
    }
}
