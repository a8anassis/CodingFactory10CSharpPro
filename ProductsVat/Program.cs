namespace ProductsVat
{
    /// <summary>
    /// Reads a product price from the console, 
    /// calculates the VAT amount (24%) and the total price, 
    /// and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            const double VAT_RATE = 0.24; // VAT rate of 24%

            double productPrice = 0.0;
            double vatAmount    = 0.0;
            double totalPrice   = 0.0;

            // Data input, data binding and validation
            Console.Write("Enter the product price: ");
            if (!double.TryParse(Console.ReadLine(), out productPrice) || productPrice <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Calculate VAT and total price
            vatAmount = productPrice * VAT_RATE;
            totalPrice = productPrice + vatAmount;

            // Print results
            Console.WriteLine($"Product Price: {productPrice:F2}");
            Console.WriteLine($"VAT Amount: {vatAmount:F2}");
            Console.WriteLine($"Total Price: {totalPrice:F2}");
        }
    }
}
