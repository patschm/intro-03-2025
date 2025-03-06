namespace TekenProgramma;

internal class Achthoek: Vorm
{
    public int Ribbe { get; set; } = 10;

    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Achthoek op ({Positie.Coordinate}) met ribbe {Ribbe}");
        Console.ResetColor();
    }

}
