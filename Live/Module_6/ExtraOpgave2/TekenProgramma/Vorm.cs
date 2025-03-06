
namespace TekenProgramma;

internal class Vorm
{
    public ConsoleColor Kleur { get; set; }
    public Positie Positie { get; set; }
    public int Lijndikte { get; set; }

    public virtual void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Vorm op ({Positie.Coordinate})");
        Console.ResetColor();
    }

}
