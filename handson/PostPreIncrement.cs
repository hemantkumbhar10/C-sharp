using System;

class OperatorC
{
    static void Main()
    {
        Console.WriteLine("Give me two numbers");
        string snum1 = Console.ReadLine();
        int num1 = int.Parse(snum1);
        string snum2 = Console.ReadLine();
        int num2 = int.Parse(snum2);

        num2 = ++num1;
        Console.WriteLine(num2);
        num2 = num1++;
        Console.WriteLine(num2);

        int swapper;

        swapper = num1;
        num1 = num2;
        num2 = swapper;

        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }
}