namespace TekenProgramma;

internal class Cirkel: Vorm
{
    private int _straal;
  
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

    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Cirkel op ({Positie.Coordinate}) met straal {Straal}");
        Console.ResetColor();
    }
}
