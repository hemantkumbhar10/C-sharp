using System;

class ArrLength
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

        int ArrLength = 1;

        foreach(int num in nums)
        {
            ArrLength++;
        }

        Console.WriteLine("The length of given array is {0}",ArrLength);
    }
}