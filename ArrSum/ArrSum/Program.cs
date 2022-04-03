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

        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }
}