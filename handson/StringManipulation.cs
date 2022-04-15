using System;

class ManString
{
    static void Main()
    {
        Console.WriteLine("Give a String");
        string name = Console.ReadLine();


        //Converting String to reverse order

        char[] nameChar = name.ToCharArray();

        string revNum = String.Empty;
        for (int i = nameChar.Length - 1; i > -1; i--)
        {
            revNum += nameChar[i].ToString();

        }
        Console.WriteLine(revNum);


        //Extract the string from second index

        string subName = name.Substring(1);
        Console.WriteLine(subName);

        //Replace any given charachter by $ sign and print new string
        Console.WriteLine("Give a Charachter to replace");
        char repChar = char.Parse(Console.ReadLine());
        Console.WriteLine(name.Replace(repChar, '$'));


        //Copy string to another variable, modify and print

        string dupName = name;

        Console.WriteLine(name);
        Console.WriteLine(dupName.Replace('m', '$'));



    }
}