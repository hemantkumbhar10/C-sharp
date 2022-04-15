using System;

class UnitPosition
{
    static void Main()
    {
        string snum1;
        string snum2;

        Console.WriteLine("Enter the number 1");
        snum1 = Console.ReadLine();
        Console.WriteLine("Enter the number 2");
        snum2 = Console.ReadLine();
        

        int num1 = int.Parse(snum1);
        int num2 = int.Parse(snum2);

        int j = num1;


        int k = 1;

        while(j != 0)
        {
            int i = j % 10;
            if (i == num2)
            {
                Console.WriteLine("yes palindrome at {0} postion", k);
                break;
            }
            else
            {
                j = j / 10;
                k = k * 10;
            }

        }
    }
}
