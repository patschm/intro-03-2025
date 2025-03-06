namespace TekenProgramma;

internal class Canvas
{
    //public List<Cirkel> cirkels = new List<Cirkel>();
    //public List<Rechthoek> rechthoeken = new List<Rechthoek>();
    //public List<Driehoek> driehoeken = new List<Driehoek>();

    private List<Vorm> vormen = new List<Vorm>();

    public void VoegToe(Vorm vorm)
    {
        //driehoeken.Add(driehoek);
        vormen.Add(vorm);
        Refresh();
    }
    //public void VoegToe(Rechthoek rechthoek)
    //{
    //    vormen.Add(rechthoek);
    //    Refresh();
    //}
    //public void VoegToe(Cirkel cirkel)
    //{
    //    vormen.Add(cirkel);
    //    Refresh();
    //}
    public void Refresh()
    {
        Console.Clear();
        foreach(Vorm vorm in vormen)
        {
            vorm.Teken();
        }
        //foreach (Rechthoek vorm in rechthoeken)
        //{
        //    vorm.Teken();
        //}
        //foreach (Cirkel vorm in cirkels)
        //{
        //    vorm.Teken();
        //}
    }
}
