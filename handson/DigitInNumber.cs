using System;

class Occurances
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        String snum = Console.ReadLine();
        Console.WriteLine("Enter the digit");
        String sdig = Console.ReadLine();
        char dig = char.Parse(sdig);

        char [] nums = snum.ToCharArray();
        int occured = 0;
        foreach(char c in nums)
        {
            if (c == dig) { occured++; }else {
                continue;

            }
        }
        Console.WriteLine("The digit {0} has occured {1} times in {2}",dig, occured, snum);
    }
}