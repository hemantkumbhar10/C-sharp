using System;

class IncreChar
{
    static void Main()
    {
        Console.WriteLine("Enter a Name: ");
        string name = Console.ReadLine();
        char[] chars = new char[name.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = name[i];
        }
 
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i]++;
        }
        Console.WriteLine(chars);

    }
}
