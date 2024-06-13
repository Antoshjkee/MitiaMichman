using MitiaMichman;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        people.Add(new Person("Mitia", 35)); // 0
        people.Add(new Person("Anton", 32)); // 1
        people.Add(new Person("Gera", 31));  // 2
        people.Add(new Person("Vasia", 18));  // 3

        var people2 = people.Where(x => x.Age >= 30)
            .Reverse();

        var overallAge = people.Sum(person => person.Age);
        Console.WriteLine(overallAge);

        foreach (Person person in people2)
        {
            Console.WriteLine(person.Name);
        }

        Console.ReadLine();
    }
    /* Section 1 */
    //Console.WriteLine("Hi, whats your name?");
    //    string nameFromConsole = Console.ReadLine();

    //Console.WriteLine($"{nameFromConsole}, how old are you?");
    //    string ageFromConsole = Console.ReadLine();

    //int age = int.Parse(ageFromConsole);
    //Person mitia = new(nameFromConsole, age, false);

    //Console.WriteLine($"Hi {mitia.Name}");
    //    Console.ReadLine();

    //    mitia.SayMyName();
    //    mitia.SayMyName();
    //    mitia.SayMyName();

    //    Person mitia = new();


    /* Section 2 */

    //Console.WriteLine("Hi, whats your name?");
    //mitia.Name = Console.ReadLine();

    //Console.WriteLine($"{mitia.Name}, how old are you?");
    //string stringNumber = Console.ReadLine();

    //bool isValidNumber = int.TryParse(stringNumber, out int age);

    //if (isValidNumber)
    //{
    //    mitia.Age = age;
    //    Console.WriteLine($"WOW {mitia.Name}, you are {mitia.Age}???");

    //    if (age < 18)
    //    {
    //        Console.WriteLine("You are too young");
    //    }
    //    else if (age >= 18 && age <= 65)
    //    {
    //        Console.WriteLine("Go back to work");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Chill brother");
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Age is incorrect");
    //}

}