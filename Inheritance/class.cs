public class Person
{

    //Properties & fields
    public int Age
    { get; private set; }

    public string Name
    { get; private set; }

    //Constructors
    public Person(string name, int age)
    {
        Age = age;
        Name = name;
    }

    //Methods
    public virtual void Introduce()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

public class Student : Person
{
    //Properties & fields
    public char Grade
    { get; private set; }

    //Constructors
    public Student(string name, int age, char grade) : base(name, age)
    { 
        Grade = grade;
    }

    //Methods
    public override void Introduce()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade {Grade}");
    }
}

public class Teacher : Person
{
    //Properties & fields
    public string Subject
    { get; private set; }

    //Constructors
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    //Methods
}