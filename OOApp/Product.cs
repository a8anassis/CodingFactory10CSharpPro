namespace OOApp;

/// <summary>
/// Defines a Product POCO class with auto-implemented properties 
/// for Id, Name, and Price.
/// </summary>
internal class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public Product()
    {
    }

    public Product(int id, string? name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string? ToString()
    {
        return $"Product: {Id} {Name} {Price:C2}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Product product &&
               Id == product.Id &&
               Name == product.Name &&
               Price == product.Price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price);
    }
}
