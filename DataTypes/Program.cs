namespace DataTypes
{
    /// <summary>
    /// Print the size in bits of the following data types: 
    /// int, long, short, byte, double, decimal, float
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"Type",-10} {"Size (bits)",-10} {"Min",-45} {"Max",-45}");
            Console.WriteLine($"{"int",-10} {sizeof(int) * 8,-10} {int.MinValue,-45} {int.MaxValue,-45}");
            Console.WriteLine($"{"byte",-10} {sizeof(byte) * 8,-10} {byte.MinValue,-45} {byte.MaxValue,-45}");
            Console.WriteLine($"{"short",-10} {sizeof(short) * 8,-10} {short.MinValue,-45} {short.MaxValue,-45}");
            Console.WriteLine($"{"long",-10} {sizeof(long) * 8,-10} {long.MinValue,-45} {long.MaxValue,-45}");   
            Console.WriteLine($"{"float",-10} {sizeof(float) * 8,-10} {float.MinValue,-45} {float.MaxValue,-45}");
            Console.WriteLine($"{"double",-10} {sizeof(double) * 8,-10} {double.MinValue,-45} {double.MaxValue,-45}");
            Console.WriteLine($"{"decimal",-10} {sizeof(decimal) * 8,-10} {decimal.MinValue,-45} {decimal.MaxValue,-45}");
        }
    }
}
