namespace AbstractApp;

internal class Cat : AbstractAnimal
{

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine($"{Name} is eating cat food.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }

    public override string ToString()
    {
        return $"Cat: {Name}, Age: {Age}";
    }
}
