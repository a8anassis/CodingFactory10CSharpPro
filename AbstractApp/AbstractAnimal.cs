namespace AbstractApp;

internal abstract class AbstractAnimal
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Age { get; set; }

    public abstract override string ToString();

    public abstract void Speak();

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}
