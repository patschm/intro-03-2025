namespace Zoo.Abstractions;

internal abstract class Verblijf
{
    private List<Dier> dieren = new List<Dier>();

    protected abstract bool KanInVerblijf(Dier dier);
    public virtual void VoegToe(Dier dier)
    {
        if (KanInVerblijf(dier))
        {
            dieren.Add(dier);
        }
        else
        {
            Console.WriteLine($"Een {dier.GetType().Name} kan niet in een {GetType().Name}");
        }
    }
    public void Rammen()
    {
        foreach (Dier dier in dieren)
        {
            dier.MaakGeluid();
        }
    }
}
