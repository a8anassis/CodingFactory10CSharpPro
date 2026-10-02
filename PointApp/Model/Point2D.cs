namespace PointApp.Model;

internal class Point2D : Point
{
    public int Y { get; set; }
    
    public Point2D()
    {
    }

    public Point2D(int x, int y) : base(x)
    {
        Y = y;
    }

    public override string ToString() => $"Point2D: ({X}, {Y})";

    public override void Move5()
    {
        base.Move5();
        Y += 5;
    }
}
