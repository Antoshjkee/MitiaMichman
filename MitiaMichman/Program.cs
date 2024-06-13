using MitiaMichman;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hi, whats your name?");
        string nameFromConsole = Console.ReadLine();

        Console.WriteLine($"{nameFromConsole}, how old are you?");
        string ageFromConsole = Console.ReadLine();

        int age = int.Parse(ageFromConsole);
        Person mitia = new(nameFromConsole, age, false);

        Console.WriteLine($"Hi {mitia.Name}");
        Console.ReadLine();

        mitia.SayMyName();
        mitia.SayMyName();
        mitia.SayMyName();

    }

    //    Person mitia = new();

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