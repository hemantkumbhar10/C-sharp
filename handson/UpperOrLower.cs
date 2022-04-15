using System;

class UpperorLower
{
    static void Main()
    {
        Console.WriteLine("Give a name");
        string name = Console.ReadLine();

        string upperName = name.ToUpper();
        string lowerName = name.ToLower();

        Console.WriteLine(upperName);
        Console.WriteLine(lowerName);

    }
}