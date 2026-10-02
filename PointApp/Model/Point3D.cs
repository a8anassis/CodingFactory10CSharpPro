
namespace PointApp.Model;

internal class Point3D : Point2D
{
    public int Z { get; set; }

    public Point3D()
    {
      
    }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }

    public override string ToString() => $"Point3D: ({X}, {Y}, {Z})";

    public override void Move5()
    {
        base.Move5();
        Z += 5;
    }
}
