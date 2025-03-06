namespace TekenProgramma;

internal class Canvas
{
    public List<Cirkel> cirkels = new List<Cirkel>();
    public List<Rechthoek> rechthoeken = new List<Rechthoek>();
    public List<Driehoek> driehoeken = new List<Driehoek>();

    public void VoegToe(Driehoek driehoek)
    {
        driehoeken.Add(driehoek);
        Refresh();
    }
    public void VoegToe(Rechthoek rechthoek)
    {
        rechthoeken.Add(rechthoek);
        Refresh();
    }
    public void VoegToe(Cirkel cirkel)
    {
        cirkels.Add(cirkel);
        Refresh();
    }
    public void Refresh()
    {
        Console.Clear();
        foreach(Driehoek vorm in driehoeken)
        {
            vorm.Teken();
        }
        foreach (Rechthoek vorm in rechthoeken)
        {
            vorm.Teken();
        }
        foreach (Cirkel vorm in cirkels)
        {
            vorm.Teken();
        }
    }
}
