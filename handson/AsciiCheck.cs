using System;
 
class AsciiChar {
 

    static void Main()

        Console.WriteLine("Enter a Charachter to check: ")
        char input = char.Parse(Console.ReadLine());
    {
        // Checking if its Alphabet
        if ((input >= 65 && input <= 90)
            || (input >= 97 && input <= 122))
            Console.WriteLine(" Its Alphabet ");
 
        // Checking if its Digits
        else if (input >= 48 && input <= 57)
            Console.WriteLine(" Its Digit ");
 
        // Otherwise give error
        else
            Console.WriteLine("Enter Valid Character");
    }
 
}