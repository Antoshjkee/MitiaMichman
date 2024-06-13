using System.Dynamic;

namespace MitiaMichman;

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool HasCats { get; set; }

    public Person(string name, int age)
    {
        if (age < 18)
        {
            throw new Exception("Person is under age");
        }

        Name = name;
        Age = age;
    }

    public Person(string name, int age, bool hasCats) 
    {
        if (age < 18)
        {
            throw new Exception("Person is under age");
        }

        Name = name;
        Age = age;
        HasCats = hasCats;
    }

    public void SayMyName()
    {
        Console.WriteLine($"MY NAME IS {Name}");
    }
}