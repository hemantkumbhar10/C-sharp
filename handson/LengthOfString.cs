using System;

class StringMan
{
    static void Main()
    {
        Console.WriteLine("Enter the name or number");
        string name = Console.ReadLine();
        int nameLen = name.Length;
        Console.WriteLine(nameLen);
    }
}