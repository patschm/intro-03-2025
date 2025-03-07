using Zoo.Abstractions;

namespace Zoo;

internal class Dierentuin
{
    private List<Verblijf> verblijven = new List<Verblijf>();

    public void Add(Verblijf verblijf)
    {
        verblijven.Add(verblijf);
    }

    public void Open()
    {
        foreach (var verblijf in verblijven)
        {
            verblijf.Rammen();
        }
    }


}
