using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Student s1 = new Student("Pablo", 16, 'B');
        Student s2 = new Student("Marta", 13, 'A');
        Student s3 = new Student("Juan", 10, 'C');
        Teacher t1 = new Teacher("Jorge", 43, "Math");
        Teacher t2 = new Teacher("Maria", 27, "History");

        List<Person> persons = new List<Person>();

        persons.Add(s1);
        persons.Add(s2);
        persons.Add(s3);
        persons.Add(t1);
        persons.Add(t2);

        foreach (Person person in persons)
        {
            if (person.IsAdult())
                Console.WriteLine("Adult");
            else
                Console.WriteLine("Minor");

            person.Introduce();
            Console.WriteLine();
        }

    }
}