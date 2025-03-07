using Zoo.Abstractions;
using Zoo.Dieren;

namespace Zoo.Verbljven;

internal class Steppe : Verblijf
{
    protected override bool KanInVerblijf(Dier dier)
    {
        return dier is Grazer;
    }
}
