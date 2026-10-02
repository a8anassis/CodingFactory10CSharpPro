using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new(15);
            Point2D p2 = new(10, 20);
            Point3D p3 = new(5, 10, 15);

            // Subtype Polymorphic behavior: a Point reference can point to a Point2D or Point3D object
            Point p4 = new(10);
            Point p5 = new Point2D(2, 7);
            Point p6 = new Point3D(1, 2, 3);

            DoMove5(p1);
            DoMove5(p2);
            DoMove5(p3);
            DoMove5(p4);
            DoMove5(p5);
            DoMove5(p6);

            DoPrint(p1);
            DoPrint(p2);
            DoPrint(p3);
            DoPrint(p4);
            DoPrint(p5);
            DoPrint(p6);
        }

        // Polymorphic method to move a point by 5 units
        public static void DoMove5(Point p)
        {
            p.Move5();
        }


        // Polymorphic method to print a point
        public static void DoPrint(Point p)
        {
            Console.WriteLine(p);
        }
    }
}
