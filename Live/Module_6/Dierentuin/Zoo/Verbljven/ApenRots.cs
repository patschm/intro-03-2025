using Zoo.Abstractions;
using Zoo.Dieren;

namespace Zoo.Verbljven;

internal class ApenRots : Verblijf
{
    protected override bool KanInVerblijf(Dier dier)
    {
        return dier is Aap;
    }
}
