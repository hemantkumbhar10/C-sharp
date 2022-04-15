using System;

class ArrReverse
{
    static void Main()
    {
        int[] nums = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("enter the number");
            int j = int.Parse(Console.ReadLine());
            nums[i] = j;
        }

        for (int k = nums.Length-1; k >=0; k--) { 
            Console.WriteLine(nums[k]);
        }

    }
}