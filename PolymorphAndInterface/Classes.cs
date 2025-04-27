abstract class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public abstract void MakeSound();

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}


public interface IAdoptable
{
    public bool IsAdopted
    { get; }

    public void Adopt();
}


class Dog : Animal, IAdoptable
{
    public bool IsAdopted
    { get; private set; }

    public string RandomDogProperty
    { get; private set; }

    public Dog(string name, int age, string randomDogProperty) : base(name, age)
    {
        RandomDogProperty = randomDogProperty;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog bark");
    }
    public void Adopt()
    {
        if (!IsAdopted)
        {
            IsAdopted = true;
            Console.WriteLine($"{Name} has been adopted!");
        }
        else
        {
            Console.WriteLine($"{Name} is already adopted!");
        }
    }
}

class Cat : Animal, IAdoptable
{
    public bool IsAdopted
    { get; private set; }

    public string RandomCatProperty
    { get; private set; }


    public Cat(string name, int age, string randomCatProperty) : base(name, age)
    {
        RandomCatProperty = randomCatProperty;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
    public void Adopt()
    {
        if (!IsAdopted)
        {
            IsAdopted = true;
            Console.WriteLine($"{Name} has been adopted!");
        }
        else
        {
            Console.WriteLine($"{Name} is already adopted!");
        }
    }
}



