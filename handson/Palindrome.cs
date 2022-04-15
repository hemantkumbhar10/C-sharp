using System;

class Palindrome
{
    static void Main()
    {
        string name;
        Console.WriteLine("Enter a name");
        name = Console.ReadLine();
        char [] chars = name.ToCharArray();
        string eman = "";
        for (int i = chars.Length-1; i >= 0; i--)
        {
            eman = eman + chars[i];
        }
        if (eman == name)
        {
            Console.WriteLine("{0} is palindrome string", name);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome string", name);
        }
    }
}