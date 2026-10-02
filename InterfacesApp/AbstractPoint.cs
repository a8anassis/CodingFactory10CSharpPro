namespace InterfacesApp;

internal abstract class AbstractPoint : IMoveable
{
    public int X { get; set; }

    public void Move5()
    {
        X += 5;
    }
    public void Move10()
    {
        X += 10;
    }
}
