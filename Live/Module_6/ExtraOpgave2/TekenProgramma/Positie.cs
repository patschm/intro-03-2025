namespace TekenProgramma;

internal class Positie
{
    public int X { get; set; }
    public int Y { get; set; }

    public string Coordinate
    {
        get
        {
            return $"({X}, {Y})";
        }
    }

}
